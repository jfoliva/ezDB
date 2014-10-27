namespace ezDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.User_text = new System.Windows.Forms.TextBox();
            this.Pass_text = new System.Windows.Forms.TextBox();
            this.User_label = new System.Windows.Forms.Label();
            this.Pass_label = new System.Windows.Forms.Label();
            this.DBName_label = new System.Windows.Forms.Label();
            this.DBname_text = new System.Windows.Forms.TextBox();
            this.Cnnt_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oracle/SQL",
            "MySQL"});
            this.comboBox1.Location = new System.Drawing.Point(26, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // User_text
            // 
            this.User_text.Location = new System.Drawing.Point(189, 75);
            this.User_text.Name = "User_text";
            this.User_text.Size = new System.Drawing.Size(144, 20);
            this.User_text.TabIndex = 1;
            // 
            // Pass_text
            // 
            this.Pass_text.Location = new System.Drawing.Point(189, 120);
            this.Pass_text.Name = "Pass_text";
            this.Pass_text.PasswordChar = '*';
            this.Pass_text.Size = new System.Drawing.Size(144, 20);
            this.Pass_text.TabIndex = 2;
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.Location = new System.Drawing.Point(86, 81);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(55, 13);
            this.User_label.TabIndex = 3;
            this.User_label.Text = "Username";
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.Location = new System.Drawing.Point(88, 127);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(53, 13);
            this.Pass_label.TabIndex = 4;
            this.Pass_label.Text = "Password";
            // 
            // DBName_label
            // 
            this.DBName_label.AutoSize = true;
            this.DBName_label.Location = new System.Drawing.Point(88, 169);
            this.DBName_label.Name = "DBName_label";
            this.DBName_label.Size = new System.Drawing.Size(84, 13);
            this.DBName_label.TabIndex = 5;
            this.DBName_label.Text = "Database Name";
            // 
            // DBname_text
            // 
            this.DBname_text.Location = new System.Drawing.Point(189, 162);
            this.DBname_text.Name = "DBname_text";
            this.DBname_text.Size = new System.Drawing.Size(144, 20);
            this.DBname_text.TabIndex = 6;
            // 
            // Cnnt_btn
            // 
            this.Cnnt_btn.Location = new System.Drawing.Point(342, 209);
            this.Cnnt_btn.Name = "Cnnt_btn";
            this.Cnnt_btn.Size = new System.Drawing.Size(75, 23);
            this.Cnnt_btn.TabIndex = 7;
            this.Cnnt_btn.Text = "Connect";
            this.Cnnt_btn.UseMnemonic = false;
            this.Cnnt_btn.UseVisualStyleBackColor = true;
            this.Cnnt_btn.Click += new System.EventHandler(this.Cnnt_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(513, 317);
            this.Controls.Add(this.Cnnt_btn);
            this.Controls.Add(this.DBname_text);
            this.Controls.Add(this.DBName_label);
            this.Controls.Add(this.Pass_label);
            this.Controls.Add(this.User_label);
            this.Controls.Add(this.Pass_text);
            this.Controls.Add(this.User_text);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox User_text;
        private System.Windows.Forms.TextBox Pass_text;
        private System.Windows.Forms.Label User_label;
        private System.Windows.Forms.Label Pass_label;
        private System.Windows.Forms.Label DBName_label;
        private System.Windows.Forms.TextBox DBname_text;
        private System.Windows.Forms.Button Cnnt_btn;
    }
}

