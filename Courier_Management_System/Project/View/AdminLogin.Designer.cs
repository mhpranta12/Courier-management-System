
namespace Project.View
{
    partial class AdminLogin
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
            this.nameTextBox = new System.Windows.Forms.RichTextBox();
            this.passwordTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(830, 416);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(423, 47);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(830, 537);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(423, 49);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(893, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(825, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Name";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginButton.Location = new System.Drawing.Point(830, 646);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(423, 55);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginClk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(825, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1102, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(637, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Admin Credential is :   username : \"admin\" password: \"1234\"  ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(827, 757);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 23);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeClk);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1842, 900);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox nameTextBox;
        private System.Windows.Forms.RichTextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}