
namespace Project.View
{
    partial class AdminDashboard
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(1304, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(366, 69);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete Shipment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.deleteShipmentButtonClk);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(852, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(366, 69);
            this.button3.TabIndex = 10;
            this.button3.Text = "Edit Shipment";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.editShipmentButtonClk);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(377, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(366, 69);
            this.button4.TabIndex = 11;
            this.button4.Text = "Add Shipment";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.addshipmentClk);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(377, 518);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(366, 69);
            this.button5.TabIndex = 12;
            this.button5.Text = "View All Shipments";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.viewallshipmentsClk);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Location = new System.Drawing.Point(852, 518);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(366, 69);
            this.button6.TabIndex = 13;
            this.button6.Text = "Acomplish a Shipment";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.completeshipmentButtonClk);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Location = new System.Drawing.Point(1304, 518);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(366, 69);
            this.button7.TabIndex = 14;
            this.button7.Text = "Log out";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.logoutButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(860, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "Admin Dashboard";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1836, 892);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
    }
}