namespace BookManager
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_insert = new System.Windows.Forms.Button();
			this.tb_page = new System.Windows.Forms.TextBox();
			this.tb_publisher = new System.Windows.Forms.TextBox();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.tb_isbn = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView_book = new System.Windows.Forms.DataGridView();
			this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isBorrowedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.borrowedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_delete);
			this.groupBox1.Controls.Add(this.btn_update);
			this.groupBox1.Controls.Add(this.btn_insert);
			this.groupBox1.Controls.Add(this.tb_page);
			this.groupBox1.Controls.Add(this.tb_publisher);
			this.groupBox1.Controls.Add(this.tb_name);
			this.groupBox1.Controls.Add(this.tb_isbn);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(456, 224);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "도서 추가/수정/삭제";
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(238, 182);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(108, 37);
			this.btn_delete.TabIndex = 6;
			this.btn_delete.Text = "삭제";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(124, 182);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(108, 37);
			this.btn_update.TabIndex = 5;
			this.btn_update.Text = "수정";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_insert
			// 
			this.btn_insert.Location = new System.Drawing.Point(10, 182);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(108, 37);
			this.btn_insert.TabIndex = 4;
			this.btn_insert.Text = "추가";
			this.btn_insert.UseVisualStyleBackColor = true;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// tb_page
			// 
			this.tb_page.Location = new System.Drawing.Point(99, 130);
			this.tb_page.Name = "tb_page";
			this.tb_page.Size = new System.Drawing.Size(153, 28);
			this.tb_page.TabIndex = 3;
			// 
			// tb_publisher
			// 
			this.tb_publisher.Location = new System.Drawing.Point(99, 96);
			this.tb_publisher.Name = "tb_publisher";
			this.tb_publisher.Size = new System.Drawing.Size(153, 28);
			this.tb_publisher.TabIndex = 3;
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(99, 62);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(153, 28);
			this.tb_name.TabIndex = 2;
			// 
			// tb_isbn
			// 
			this.tb_isbn.Location = new System.Drawing.Point(99, 25);
			this.tb_isbn.Name = "tb_isbn";
			this.tb_isbn.Size = new System.Drawing.Size(153, 28);
			this.tb_isbn.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "페이지";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "출판사";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "도서 이름";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Isbn";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView_book);
			this.groupBox2.Location = new System.Drawing.Point(12, 242);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1375, 466);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "도서 현황";
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
			this.dataGridView_book.Size = new System.Drawing.Size(1363, 433);
			this.dataGridView_book.TabIndex = 0;
			this.dataGridView_book.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
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
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1394, 720);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form2";
			this.Text = "도서 관리";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_book)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.TextBox tb_page;
		private System.Windows.Forms.TextBox tb_publisher;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.TextBox tb_isbn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView_book;
		private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isBorrowedDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn borrowedAtDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource bookBindingSource;
	}
}