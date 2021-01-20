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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();

			// 데이터 그리드 설정
			dataGridView_user.DataSource = DataManager.Users;
		}

		private void dataGridView_user_CurrentCellChanged(object sender, EventArgs e)
		{
			try
			{
				// 그리드의 셀이 선택되면 텍스트 박스에 글자 지정
				User user = dataGridView_user.CurrentRow.DataBoundItem as User;
				tb_userId.Text = user.Id.ToString();
				tb_name.Text = user.Name;
			}
			catch (Exception exception)
			{

			}
		}

		private void btn_insert_Click(object sender, EventArgs e)
		{
			try
			{
				if (DataManager.Users.Exists((x) => x.Id == int.Parse(tb_userId.Text)))
				{
					MessageBox.Show("사용자 ID가 겹칩니다");
				}
				else
				{
					User user = new User()
					{
						Id = int.Parse(tb_userId.Text),
						Name = tb_name.Text
					};
					DataManager.Users.Add(user);

					dataGridView_user.DataSource = null;
					dataGridView_user.DataSource = DataManager.Users;
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
				User user = DataManager.Users.Single((x) => x.Id == int.Parse(tb_userId.Text));
				user.Name = tb_name.Text;

				dataGridView_user.DataSource = null;
				dataGridView_user.DataSource = DataManager.Users;
				DataManager.Save();
			}
			catch (Exception exception)
			{
				MessageBox.Show("존재하지 않는 사용자입니다,");
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			try
			{
				User user = DataManager.Users.Single((x) => x.Id == int.Parse(tb_userId.Text));
				DataManager.Users.Remove(user);

				dataGridView_user.DataSource = null;
				dataGridView_user.DataSource = DataManager.Users;
				DataManager.Save();
			}
			catch (Exception exception)
			{
				MessageBox.Show("존재하지 않는 사용자입니다,");
			}
		}
	}
}
