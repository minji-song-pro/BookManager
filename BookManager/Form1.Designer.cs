namespace BookManager
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.도서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.사용자관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lb_delayBorrowedCount = new System.Windows.Forms.Label();
			this.lb_isBorrowedCount = new System.Windows.Forms.Label();
			this.lb_userCount = new System.Windows.Forms.Label();
			this.lb_totalBookCount = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_borrow = new System.Windows.Forms.Button();
			this.btn_return = new System.Windows.Forms.Button();
			this.tb_userId = new System.Windows.Forms.TextBox();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.tb_isbn = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView_book = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGridView_user = new System.Windows.Forms.DataGridView();
			this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isBorrowedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.borrowedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도서관리ToolStripMenuItem,
            this.사용자관리ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1451, 36);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 도서관리ToolStripMenuItem
			// 
			this.도서관리ToolStripMenuItem.Name = "도서관리ToolStripMenuItem";
			this.도서관리ToolStripMenuItem.Size = new System.Drawing.Size(106, 30);
			this.도서관리ToolStripMenuItem.Text = "도서 관리";
			this.도서관리ToolStripMenuItem.Click += new System.EventHandler(this.도서관리ToolStripMenuItem_Click);
			// 
			// 사용자관리ToolStripMenuItem
			// 
			this.사용자관리ToolStripMenuItem.Name = "사용자관리ToolStripMenuItem";
			this.사용자관리ToolStripMenuItem.Size = new System.Drawing.Size(124, 30);
			this.사용자관리ToolStripMenuItem.Text = "사용자 관리";
			this.사용자관리ToolStripMenuItem.Click += new System.EventHandler(this.사용자관리ToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lb_delayBorrowedCount);
			this.groupBox1.Controls.Add(this.lb_isBorrowedCount);
			this.groupBox1.Controls.Add(this.lb_userCount);
			this.groupBox1.Controls.Add(this.lb_totalBookCount);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 36);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(544, 149);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "도서관 현황";
			// 
			// lb_delayBorrowedCount
			// 
			this.lb_delayBorrowedCount.AutoSize = true;
			this.lb_delayBorrowedCount.Location = new System.Drawing.Point(188, 115);
			this.lb_delayBorrowedCount.Name = "lb_delayBorrowedCount";
			this.lb_delayBorrowedCount.Size = new System.Drawing.Size(18, 18);
			this.lb_delayBorrowedCount.TabIndex = 7;
			this.lb_delayBorrowedCount.Text = "0";
			// 
			// lb_isBorrowedCount
			// 
			this.lb_isBorrowedCount.AutoSize = true;
			this.lb_isBorrowedCount.Location = new System.Drawing.Point(188, 86);
			this.lb_isBorrowedCount.Name = "lb_isBorrowedCount";
			this.lb_isBorrowedCount.Size = new System.Drawing.Size(18, 18);
			this.lb_isBorrowedCount.TabIndex = 6;
			this.lb_isBorrowedCount.Text = "0";
			// 
			// lb_userCount
			// 
			this.lb_userCount.AutoSize = true;
			this.lb_userCount.Location = new System.Drawing.Point(104, 55);
			this.lb_userCount.Name = "lb_userCount";
			this.lb_userCount.Size = new System.Drawing.Size(18, 18);
			this.lb_userCount.TabIndex = 5;
			this.lb_userCount.Text = "0";
			// 
			// lb_totalBookCount
			// 
			this.lb_totalBookCount.AutoSize = true;
			this.lb_totalBookCount.Location = new System.Drawing.Point(128, 24);
			this.lb_totalBookCount.Name = "lb_totalBookCount";
			this.lb_totalBookCount.Size = new System.Drawing.Size(18, 18);
			this.lb_totalBookCount.TabIndex = 4;
			this.lb_totalBookCount.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "연체 중인 도서의 수:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "대출 중인 도서의 수:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "사용자 수:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "전체 도서 수:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_borrow);
			this.groupBox2.Controls.Add(this.btn_return);
			this.groupBox2.Controls.Add(this.tb_userId);
			this.groupBox2.Controls.Add(this.tb_name);
			this.groupBox2.Controls.Add(this.tb_isbn);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(562, 36);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(384, 149);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "대여/반납";
			// 
			// btn_borrow
			// 
			this.btn_borrow.Location = new System.Drawing.Point(275, 21);
			this.btn_borrow.Name = "btn_borrow";
			this.btn_borrow.Size = new System.Drawing.Size(96, 28);
			this.btn_borrow.TabIndex = 3;
			this.btn_borrow.Text = "대여";
			this.btn_borrow.UseVisualStyleBackColor = true;
			this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
			// 
			// btn_return
			// 
			this.btn_return.Location = new System.Drawing.Point(275, 55);
			this.btn_return.Name = "btn_return";
			this.btn_return.Size = new System.Drawing.Size(96, 28);
			this.btn_return.TabIndex = 4;
			this.btn_return.Text = "반납";
			this.btn_return.UseVisualStyleBackColor = true;
			this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
			// 
			// tb_userId
			// 
			this.tb_userId.Location = new System.Drawing.Point(108, 86);
			this.tb_userId.Name = "tb_userId";
			this.tb_userId.Size = new System.Drawing.Size(147, 28);
			this.tb_userId.TabIndex = 11;
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(108, 55);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(147, 28);
			this.tb_name.TabIndex = 10;
			// 
			// tb_isbn
			// 
			this.tb_isbn.Location = new System.Drawing.Point(108, 21);
			this.tb_isbn.Name = "tb_isbn";
			this.tb_isbn.Size = new System.Drawing.Size(147, 28);
			this.tb_isbn.TabIndex = 9;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 89);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 18);
			this.label11.TabIndex = 8;
			this.label11.Text = "사용자 ID";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 58);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 18);
			this.label10.TabIndex = 8;
			this.label10.Text = "도서 이름";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 18);
			this.label9.TabIndex = 8;
			this.label9.Text = "Isbn";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView_book);
			this.groupBox3.Location = new System.Drawing.Point(12, 191);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1428, 444);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "도서 현황";
			// 
			// dataGridView_book
			// 
			this.dataGridView_book.AutoGenerateColumns = false;
			this.dataGridView_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.isBorrowedDataGridViewCheckBoxColumn,
            this.borrowedAtDataGridViewTextBoxColumn});
			this.dataGridView_book.DataSource = this.bookBindingSource;
			this.dataGridView_book.Location = new System.Drawing.Point(6, 27);
			this.dataGridView_book.Name = "dataGridView_book";
			this.dataGridView_book.RowHeadersWidth = 62;
			this.dataGridView_book.RowTemplate.Height = 30;
			this.dataGridView_book.Size = new System.Drawing.Size(1416, 411);
			this.dataGridView_book.TabIndex = 0;
			this.dataGridView_book.CurrentCellChanged += new System.EventHandler(this.dataGridView_book_CurrentCellChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dataGridView_user);
			this.groupBox4.Location = new System.Drawing.Point(12, 641);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1428, 192);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "사용자 현황";
			// 
			// dataGridView_user
			// 
			this.dataGridView_user.AutoGenerateColumns = false;
			this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
			this.dataGridView_user.DataSource = this.userBindingSource;
			this.dataGridView_user.Location = new System.Drawing.Point(6, 27);
			this.dataGridView_user.Name = "dataGridView_user";
			this.dataGridView_user.RowHeadersWidth = 62;
			this.dataGridView_user.RowTemplate.Height = 30;
			this.dataGridView_user.Size = new System.Drawing.Size(1416, 159);
			this.dataGridView_user.TabIndex = 0;
			this.dataGridView_user.CurrentCellChanged += new System.EventHandler(this.dataGridView_user_CurrentCellChanged);
			// 
			// bookBindingSource
			// 
			this.bookBindingSource.DataSource = typeof(BookManager.Book);
			// 
			// isbnDataGridViewTextBoxColumn
			// 
			this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
			this.isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
			this.isbnDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
			this.isbnDataGridViewTextBoxColumn.Width = 150;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 150;
			// 
			// publisherDataGridViewTextBoxColumn
			// 
			this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
			this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
			this.publisherDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
			this.publisherDataGridViewTextBoxColumn.Width = 150;
			// 
			// pageDataGridViewTextBoxColumn
			// 
			this.pageDataGridViewTextBoxColumn.DataPropertyName = "Page";
			this.pageDataGridViewTextBoxColumn.HeaderText = "Page";
			this.pageDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.pageDataGridViewTextBoxColumn.Name = "pageDataGridViewTextBoxColumn";
			this.pageDataGridViewTextBoxColumn.Width = 150;
			// 
			// userIdDataGridViewTextBoxColumn
			// 
			this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
			this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
			this.userIdDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
			this.userIdDataGridViewTextBoxColumn.Width = 150;
			// 
			// userNameDataGridViewTextBoxColumn
			// 
			this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
			this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
			this.userNameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
			this.userNameDataGridViewTextBoxColumn.Width = 150;
			// 
			// isBorrowedDataGridViewCheckBoxColumn
			// 
			this.isBorrowedDataGridViewCheckBoxColumn.DataPropertyName = "isBorrowed";
			this.isBorrowedDataGridViewCheckBoxColumn.HeaderText = "isBorrowed";
			this.isBorrowedDataGridViewCheckBoxColumn.MinimumWidth = 8;
			this.isBorrowedDataGridViewCheckBoxColumn.Name = "isBorrowedDataGridViewCheckBoxColumn";
			this.isBorrowedDataGridViewCheckBoxColumn.Width = 150;
			// 
			// borrowedAtDataGridViewTextBoxColumn
			// 
			this.borrowedAtDataGridViewTextBoxColumn.DataPropertyName = "BorrowedAt";
			this.borrowedAtDataGridViewTextBoxColumn.HeaderText = "BorrowedAt";
			this.borrowedAtDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.borrowedAtDataGridViewTextBoxColumn.Name = "borrowedAtDataGridViewTextBoxColumn";
			this.borrowedAtDataGridViewTextBoxColumn.Width = 150;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(BookManager.User);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Width = 150;
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn1.MinimumWidth = 8;
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.Width = 150;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1451, 845);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "도서관 관리";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 도서관리ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 사용자관리ToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lb_delayBorrowedCount;
		private System.Windows.Forms.Label lb_isBorrowedCount;
		private System.Windows.Forms.Label lb_userCount;
		private System.Windows.Forms.Label lb_totalBookCount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btn_borrow;
		private System.Windows.Forms.Button btn_return;
		private System.Windows.Forms.TextBox tb_userId;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.TextBox tb_isbn;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView_book;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dataGridView_user;
		private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isBorrowedDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn borrowedAtDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource bookBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.BindingSource userBindingSource;
	}
}

