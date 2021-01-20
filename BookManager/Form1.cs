using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			//라벨 설정
			lb_totalBookCount.Text = DataManager.Books.Count.ToString();
			lb_userCount.Text = DataManager.Users.Count.ToString();
			lb_isBorrowedCount.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
			lb_delayBorrowedCount.Text = DataManager.Books.Where((x) =>
			{
				return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now;
			}).Count().ToString();

			//데이터 그리드 설정
			dataGridView_book.DataSource = DataManager.Books;
			dataGridView_user.DataSource = DataManager.Users;
		}

		private void dataGridView_book_CurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				// 그리드의 셀이 선택되면 텍스트 박스에 글자 지정
				Book book = dataGridView_book.CurrentRow.DataBoundItem as Book;
				tb_isbn.Text = book.Isbn;
				tb_name.Text = book.Name;
			}
			catch (Exception exception)
			{

			}
		}

		private void dataGridView_user_CurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				// 그리드의 셀이 선택되면 텍스트 박스에 글자 지정
				User user = dataGridView_user.CurrentRow.DataBoundItem as User;
				tb_userId.Text = user.Id.ToString();
			}
			catch (Exception exception)
			{

			}
		}

		private void btn_return_Click(object sender, EventArgs e)
		{
			if (tb_isbn.Text.Trim() == "")
			{
				MessageBox.Show("Isbn을 입력해주세요");
			}
			else if (tb_userId.Text.Trim() == "")
			{
				MessageBox.Show("사용자 Id를 입력해주세요");
			}
			else
			{
				try
				{
					Book book = DataManager.Books.Single((x) => x.Isbn == tb_isbn.Text);
					if (book.isBorrowed)
					{
						MessageBox.Show("이미 대여 중인 도서입니다.");
					}
					else
					{
						User user = DataManager.Users.Single((x) => x.Id.ToString() == tb_userId.Text);
						book.UserId = user.Id;
						book.UserName = user.Name;
						book.isBorrowed = true;
						book.BorrowedAt = DateTime.Now;

						dataGridView_book.DataSource = null;
						dataGridView_book.DataSource = DataManager.Books;
						DataManager.Save();

						MessageBox.Show(book.Name + "이/가" + user.Name + "님께 대여되었습니다.");
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
				}
			}
		}

		private void btn_borrow_Click(object sender, EventArgs e)
		{
			if (tb_isbn.Text.Trim() == "")
			{
				MessageBox.Show("Isbn을 입력해주세요");
			}
			else
			{
				try
				{
					Book book = DataManager.Books.Single((x) => x.Isbn == tb_isbn.Text);
					if(book.isBorrowed)
					{
						User user = DataManager.Users.Single((x) => x.Id.ToString() == book.UserId.ToString());
						book.UserId = 0;
						book.UserName = "";
						book.isBorrowed = false;
						book.BorrowedAt = new DateTime();

						dataGridView_book.DataSource = null;
						dataGridView_book.DataSource = DataManager.Books;
						DataManager.Save();

						if(book.BorrowedAt.AddDays(7) > DateTime.Now)
						{
							MessageBox.Show(book.Name + "이/가 연체 상태로 반납되었습니다.");
						}
						else
						{
							MessageBox.Show(book.Name + "이/가 반납되었습니다.");
						}
					}
					else
					{
						MessageBox.Show("대여 상태가 아닙니다.");
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
				}
			}
		}

		private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Form2().ShowDialog();
		}

		private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Form3().ShowDialog();
		}
	}
}
