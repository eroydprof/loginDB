namespace DbConnection
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIdPengguna = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CBLevel = new System.Windows.Forms.ComboBox();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnCari = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(869, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Pengguna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status";
            // 
            // TxtIdPengguna
            // 
            this.TxtIdPengguna.Location = new System.Drawing.Point(209, 32);
            this.TxtIdPengguna.Name = "TxtIdPengguna";
            this.TxtIdPengguna.Size = new System.Drawing.Size(100, 31);
            this.TxtIdPengguna.TabIndex = 6;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(209, 98);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(242, 31);
            this.TxtUsername.TabIndex = 7;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(209, 154);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(242, 31);
            this.TxtPassword.TabIndex = 8;
            // 
            // CBLevel
            // 
            this.CBLevel.FormattingEnabled = true;
            this.CBLevel.Items.AddRange(new object[] {
            "-",
            "1",
            "2"});
            this.CBLevel.Location = new System.Drawing.Point(209, 205);
            this.CBLevel.Name = "CBLevel";
            this.CBLevel.Size = new System.Drawing.Size(121, 33);
            this.CBLevel.TabIndex = 9;
            // 
            // CBStatus
            // 
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "-",
            "aktif",
            "tidak"});
            this.CBStatus.Location = new System.Drawing.Point(209, 257);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(121, 33);
            this.CBStatus.TabIndex = 10;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(591, 32);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(134, 51);
            this.BtnSimpan.TabIndex = 11;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnCari
            // 
            this.BtnCari.Location = new System.Drawing.Point(747, 35);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(134, 51);
            this.BtnCari.TabIndex = 12;
            this.BtnCari.Text = "Cari";
            this.BtnCari.UseVisualStyleBackColor = true;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(591, 101);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(134, 51);
            this.BtnUpdate.TabIndex = 13;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(747, 98);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(134, 51);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(747, 239);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(134, 51);
            this.BtnClear.TabIndex = 15;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 670);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.CBStatus);
            this.Controls.Add(this.CBLevel);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtIdPengguna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIdPengguna;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.ComboBox CBLevel;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnCari;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClear;
    }
}

