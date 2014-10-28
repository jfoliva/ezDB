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
            this.txtBx_SrvrName = new System.Windows.Forms.TextBox();
            this.lbl_SrvrName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oracle/SQL",
            "MySQL"});
            this.comboBox1.Location = new System.Drawing.Point(39, 49);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // User_text
            // 
            this.User_text.Location = new System.Drawing.Point(293, 124);
            this.User_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.User_text.Name = "User_text";
            this.User_text.Size = new System.Drawing.Size(214, 26);
            this.User_text.TabIndex = 1;
            // 
            // Pass_text
            // 
            this.Pass_text.Location = new System.Drawing.Point(293, 160);
            this.Pass_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pass_text.Name = "Pass_text";
            this.Pass_text.PasswordChar = '*';
            this.Pass_text.Size = new System.Drawing.Size(214, 26);
            this.Pass_text.TabIndex = 2;
            // 
            // User_label
            // 
            this.User_label.AutoSize = true;
            this.User_label.BackColor = System.Drawing.Color.Transparent;
            this.User_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.User_label.Location = new System.Drawing.Point(129, 125);
            this.User_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_label.Name = "User_label";
            this.User_label.Size = new System.Drawing.Size(102, 25);
            this.User_label.TabIndex = 6;
            this.User_label.Text = "Username";
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.BackColor = System.Drawing.Color.Transparent;
            this.Pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Pass_label.Location = new System.Drawing.Point(132, 161);
            this.Pass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(98, 25);
            this.Pass_label.TabIndex = 7;
            this.Pass_label.Text = "Password";
            // 
            // DBName_label
            // 
            this.DBName_label.AutoSize = true;
            this.DBName_label.BackColor = System.Drawing.Color.Transparent;
            this.DBName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBName_label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DBName_label.Location = new System.Drawing.Point(129, 233);
            this.DBName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DBName_label.Name = "DBName_label";
            this.DBName_label.Size = new System.Drawing.Size(153, 25);
            this.DBName_label.TabIndex = 9;
            this.DBName_label.Text = "Database Name";
            // 
            // DBname_text
            // 
            this.DBname_text.Location = new System.Drawing.Point(293, 232);
            this.DBname_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DBname_text.Name = "DBname_text";
            this.DBname_text.Size = new System.Drawing.Size(214, 26);
            this.DBname_text.TabIndex = 4;
            // 
            // Cnnt_btn
            // 
            this.Cnnt_btn.Location = new System.Drawing.Point(525, 325);
            this.Cnnt_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cnnt_btn.Name = "Cnnt_btn";
            this.Cnnt_btn.Size = new System.Drawing.Size(112, 35);
            this.Cnnt_btn.TabIndex = 5;
            this.Cnnt_btn.Text = "Connect";
            this.Cnnt_btn.UseMnemonic = false;
            this.Cnnt_btn.UseVisualStyleBackColor = true;
            this.Cnnt_btn.Click += new System.EventHandler(this.Cnnt_btn_Click);
            // 
            // txtBx_SrvrName
            // 
            this.txtBx_SrvrName.Location = new System.Drawing.Point(293, 196);
            this.txtBx_SrvrName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBx_SrvrName.Name = "txtBx_SrvrName";
            this.txtBx_SrvrName.Size = new System.Drawing.Size(214, 26);
            this.txtBx_SrvrName.TabIndex = 3;
            // 
            // lbl_SrvrName
            // 
            this.lbl_SrvrName.AutoSize = true;
            this.lbl_SrvrName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SrvrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SrvrName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_SrvrName.Location = new System.Drawing.Point(129, 197);
            this.lbl_SrvrName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SrvrName.Name = "lbl_SrvrName";
            this.lbl_SrvrName.Size = new System.Drawing.Size(127, 25);
            this.lbl_SrvrName.TabIndex = 8;
            this.lbl_SrvrName.Text = "Server Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(770, 488);
            this.Controls.Add(this.txtBx_SrvrName);
            this.Controls.Add(this.lbl_SrvrName);
            this.Controls.Add(this.Cnnt_btn);
            this.Controls.Add(this.DBname_text);
            this.Controls.Add(this.DBName_label);
            this.Controls.Add(this.Pass_label);
            this.Controls.Add(this.User_label);
            this.Controls.Add(this.Pass_text);
            this.Controls.Add(this.User_text);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Welcome to ezDB";
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
        private System.Windows.Forms.TextBox txtBx_SrvrName;
        private System.Windows.Forms.Label lbl_SrvrName;
    }
}

