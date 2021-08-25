
namespace Project.View
{
    partial class UpdateShipment
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
            this.label11 = new System.Windows.Forms.Label();
            this.statuscomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.update_ShipmentButton = new System.Windows.Forms.Button();
            this.mobileTextBox = new System.Windows.Forms.RichTextBox();
            this.final_dateTextBox = new System.Windows.Forms.RichTextBox();
            this.date_of_placementTextBox = new System.Windows.Forms.RichTextBox();
            this.addressTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.product_nameTextBox = new System.Windows.Forms.RichTextBox();
            this.customer_nameTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.delivery_timeTextBox = new System.Windows.Forms.RichTextBox();
            this.delivery_placeTextBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.consignment_noTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1154, 777);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 28);
            this.label11.TabIndex = 50;
            this.label11.Text = "Status";
            // 
            // statuscomboBox
            // 
            this.statuscomboBox.FormattingEnabled = true;
            this.statuscomboBox.Items.AddRange(new object[] {
            "not delivered",
            "on process",
            "delivered"});
            this.statuscomboBox.Location = new System.Drawing.Point(1149, 837);
            this.statuscomboBox.Name = "statuscomboBox";
            this.statuscomboBox.Size = new System.Drawing.Size(380, 24);
            this.statuscomboBox.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(648, 661);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 28);
            this.label10.TabIndex = 48;
            this.label10.Text = "Mobile No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1154, 661);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 28);
            this.label9.TabIndex = 47;
            this.label9.Text = "Final Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1144, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 28);
            this.label8.TabIndex = 46;
            this.label8.Text = "Date of Delivery Placement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(638, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 45;
            this.label5.Text = "Address";
            // 
            // update_ShipmentButton
            // 
            this.update_ShipmentButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update_ShipmentButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_ShipmentButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.update_ShipmentButton.Location = new System.Drawing.Point(643, 922);
            this.update_ShipmentButton.Name = "update_ShipmentButton";
            this.update_ShipmentButton.Size = new System.Drawing.Size(467, 57);
            this.update_ShipmentButton.TabIndex = 44;
            this.update_ShipmentButton.Text = "Update";
            this.update_ShipmentButton.UseVisualStyleBackColor = false;
            this.update_ShipmentButton.Click += new System.EventHandler(this.update_ShipmentButtonClk);
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(643, 702);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(380, 49);
            this.mobileTextBox.TabIndex = 43;
            this.mobileTextBox.Text = "";
            // 
            // final_dateTextBox
            // 
            this.final_dateTextBox.Location = new System.Drawing.Point(1149, 702);
            this.final_dateTextBox.Name = "final_dateTextBox";
            this.final_dateTextBox.Size = new System.Drawing.Size(380, 49);
            this.final_dateTextBox.TabIndex = 42;
            this.final_dateTextBox.Text = "";
            // 
            // date_of_placementTextBox
            // 
            this.date_of_placementTextBox.Location = new System.Drawing.Point(1149, 586);
            this.date_of_placementTextBox.Name = "date_of_placementTextBox";
            this.date_of_placementTextBox.Size = new System.Drawing.Size(380, 49);
            this.date_of_placementTextBox.TabIndex = 41;
            this.date_of_placementTextBox.Text = "";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(643, 586);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(380, 49);
            this.addressTextBox.TabIndex = 40;
            this.addressTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(805, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 38);
            this.label2.TabIndex = 51;
            this.label2.Text = "Edit/Update    Shipment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(638, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 28);
            this.label4.TabIndex = 55;
            this.label4.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 28);
            this.label3.TabIndex = 54;
            this.label3.Text = "Customer name";
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.Location = new System.Drawing.Point(643, 479);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(380, 49);
            this.product_nameTextBox.TabIndex = 53;
            this.product_nameTextBox.Text = "";
            // 
            // customer_nameTextBox
            // 
            this.customer_nameTextBox.Location = new System.Drawing.Point(643, 381);
            this.customer_nameTextBox.Name = "customer_nameTextBox";
            this.customer_nameTextBox.Size = new System.Drawing.Size(380, 49);
            this.customer_nameTextBox.TabIndex = 52;
            this.customer_nameTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1144, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 28);
            this.label7.TabIndex = 59;
            this.label7.Text = "Delivery Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1144, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 28);
            this.label6.TabIndex = 58;
            this.label6.Text = "Delivery Place ";
            // 
            // delivery_timeTextBox
            // 
            this.delivery_timeTextBox.Location = new System.Drawing.Point(1149, 479);
            this.delivery_timeTextBox.Name = "delivery_timeTextBox";
            this.delivery_timeTextBox.Size = new System.Drawing.Size(380, 49);
            this.delivery_timeTextBox.TabIndex = 57;
            this.delivery_timeTextBox.Text = "";
            // 
            // delivery_placeTextBox
            // 
            this.delivery_placeTextBox.Location = new System.Drawing.Point(1149, 381);
            this.delivery_placeTextBox.Name = "delivery_placeTextBox";
            this.delivery_placeTextBox.Size = new System.Drawing.Size(380, 49);
            this.delivery_placeTextBox.TabIndex = 56;
            this.delivery_placeTextBox.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(460, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 28);
            this.label12.TabIndex = 61;
            this.label12.Text = "Consignment Number";
            // 
            // consignment_noTextBox
            // 
            this.consignment_noTextBox.Location = new System.Drawing.Point(643, 281);
            this.consignment_noTextBox.Name = "consignment_noTextBox";
            this.consignment_noTextBox.Size = new System.Drawing.Size(380, 49);
            this.consignment_noTextBox.TabIndex = 60;
            this.consignment_noTextBox.Text = "";
            // 
            // UpdateShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.consignment_noTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delivery_timeTextBox);
            this.Controls.Add(this.delivery_placeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(this.customer_nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.statuscomboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.update_ShipmentButton);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.final_dateTextBox);
            this.Controls.Add(this.date_of_placementTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Name = "UpdateShipment";
            this.Text = "UpdateShipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox statuscomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update_ShipmentButton;
        private System.Windows.Forms.RichTextBox mobileTextBox;
        private System.Windows.Forms.RichTextBox final_dateTextBox;
        private System.Windows.Forms.RichTextBox date_of_placementTextBox;
        private System.Windows.Forms.RichTextBox addressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox product_nameTextBox;
        private System.Windows.Forms.RichTextBox customer_nameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox delivery_timeTextBox;
        private System.Windows.Forms.RichTextBox delivery_placeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox consignment_noTextBox;
    }
}