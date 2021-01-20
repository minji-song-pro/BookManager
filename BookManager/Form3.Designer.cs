namespace BookManager
{
	partial class Form3
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_insert = new System.Windows.Forms.Button();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.tb_userId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView_user = new System.Windows.Forms.DataGridView();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView_user);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(578, 708);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "사용자 현황";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_delete);
			this.groupBox2.Controls.Add(this.btn_update);
			this.groupBox2.Controls.Add(this.btn_insert);
			this.groupBox2.Controls.Add(this.tb_name);
			this.groupBox2.Controls.Add(this.tb_userId);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(596, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(422, 197);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "사용자 추가/수정/삭제";
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(234, 153);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(108, 37);
			this.btn_delete.TabIndex = 9;
			this.btn_delete.Text = "삭제";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(120, 153);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(108, 37);
			this.btn_update.TabIndex = 8;
			this.btn_update.Text = "수정";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_insert
			// 
			this.btn_insert.Location = new System.Drawing.Point(6, 153);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(108, 37);
			this.btn_insert.TabIndex = 7;
			this.btn_insert.Text = "추가";
			this.btn_insert.UseVisualStyleBackColor = true;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(94, 58);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(169, 28);
			this.tb_name.TabIndex = 2;
			// 
			// tb_userId
			// 
			this.tb_userId.Location = new System.Drawing.Point(94, 24);
			this.tb_userId.Name = "tb_userId";
			this.tb_userId.Size = new System.Drawing.Size(169, 28);
			this.tb_userId.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "이름";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "사용자 ID";
			// 
			// dataGridView_user
			// 
			this.dataGridView_user.AutoGenerateColumns = false;
			this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
			this.dataGridView_user.DataSource = this.userBindingSource;
			this.dataGridView_user.Location = new System.Drawing.Point(6, 24);
			this.dataGridView_user.Name = "dataGridView_user";
			this.dataGridView_user.RowHeadersWidth = 62;
			this.dataGridView_user.RowTemplate.Height = 30;
			this.dataGridView_user.Size = new System.Drawing.Size(566, 678);
			this.dataGridView_user.TabIndex = 0;
			this.dataGridView_user.CurrentCellChanged += new System.EventHandler(this.dataGridView_user_CurrentCellChanged);
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
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 150;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1027, 731);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form3";
			this.Text = "사용자 관리";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.TextBox tb_userId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.DataGridView dataGridView_user;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource userBindingSource;
	}
}