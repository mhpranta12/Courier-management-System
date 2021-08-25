
namespace Project.View
{
    partial class User
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
            this.label2 = new System.Windows.Forms.Label();
            this.consignment_noTextBox = new System.Windows.Forms.RichTextBox();
            this.insert_ShipmentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.foundListGridview = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.foundListGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 38);
            this.label2.TabIndex = 44;
            this.label2.Text = "User Page";
            // 
            // consignment_noTextBox
            // 
            this.consignment_noTextBox.Location = new System.Drawing.Point(158, 397);
            this.consignment_noTextBox.Name = "consignment_noTextBox";
            this.consignment_noTextBox.Size = new System.Drawing.Size(380, 49);
            this.consignment_noTextBox.TabIndex = 45;
            this.consignment_noTextBox.Text = "";
            // 
            // insert_ShipmentButton
            // 
            this.insert_ShipmentButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insert_ShipmentButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_ShipmentButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.insert_ShipmentButton.Location = new System.Drawing.Point(158, 479);
            this.insert_ShipmentButton.Name = "insert_ShipmentButton";
            this.insert_ShipmentButton.Size = new System.Drawing.Size(247, 49);
            this.insert_ShipmentButton.TabIndex = 46;
            this.insert_ShipmentButton.Text = "Search";
            this.insert_ShipmentButton.UseVisualStyleBackColor = false;
            this.insert_ShipmentButton.Click += new System.EventHandler(this.searchButtonClk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Consignment Number ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(154, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Check Progress Of your Product";
            // 
            // foundListGridview
            // 
            this.foundListGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foundListGridview.Location = new System.Drawing.Point(607, 397);
            this.foundListGridview.Name = "foundListGridview";
            this.foundListGridview.RowHeadersWidth = 51;
            this.foundListGridview.RowTemplate.Height = 24;
            this.foundListGridview.Size = new System.Drawing.Size(929, 180);
            this.foundListGridview.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 33);
            this.label4.TabIndex = 50;
            this.label4.Text = "Info of your product";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1101, 235);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 25);
            this.linkLabel1.TabIndex = 51;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeClk);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1835, 887);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.foundListGridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert_ShipmentButton);
            this.Controls.Add(this.consignment_noTextBox);
            this.Controls.Add(this.label2);
            this.Name = "User";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.foundListGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox consignment_noTextBox;
        private System.Windows.Forms.Button insert_ShipmentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView foundListGridview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}