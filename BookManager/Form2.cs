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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();

			// 데이터 그리드 설정
			dataGridView_book.DataSource = DataManager.Books;
		}

		private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				// 그리드의 셀이 선택되면 텍스트 박스에 글자 지정
				Book book = dataGridView_book.CurrentRow.DataBoundItem as Book;
				tb_isbn.Text = book.Isbn;
				tb_name.Text = book.Name;
				tb_publisher.Text = book.Publisher;
				tb_page.Text = book.Page.ToString();
			}
			catch (Exception exception)
			{

			}
		}

		private void btn_insert_Click(object sender, EventArgs e)
		{
			try
			{
				if (DataManager.Books.Exists((x) => x.Isbn == tb_isbn.Text))
				{
					MessageBox.Show("이미 존재하는 도서입니다.");
				}
				else
				{
					Book book = new Book()
					{
						Isbn = tb_isbn.Text,
						Name = tb_name.Text,
						Publisher = tb_publisher.Text,
						Page = int.Parse(tb_page.Text)
					};
					DataManager.Books.Add(book);

					dataGridView_book.DataSource = null;
					dataGridView_book.DataSource = DataManager.Books;
					DataManager.Save();
				}
			}
			catch (Exception exception)
			{

			}
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			try
			{
				Book book = DataManager.Books.Single((x) => x.Isbn == tb_isbn.Text);
				book.UserName = tb_name.Text;
				book.Publisher = tb_publisher.Text;
				book.Page = int.Parse(tb_page.Text);

				dataGridView_book.DataSource = null;
				dataGridView_book.DataSource = DataManager.Books;
				DataManager.Save();
			}
			catch (Exception exception)
			{
				MessageBox.Show("존재하지 않는 도서입니다,");
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			try
			{
				Book book = DataManager.Books.Single((x) => x.Isbn == tb_isbn.Text);
				DataManager.Books.Remove(book);

				dataGridView_book.DataSource = null;
				dataGridView_book.DataSource = DataManager.Books;
				DataManager.Save();
			}
			catch (Exception exception)
			{
				MessageBox.Show("존재하지 않는 도서입니다,");
			}
		}
	}
}
