
namespace Project.View
{
    partial class CompleteDelivery
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
            this.label12 = new System.Windows.Forms.Label();
            this.consignment_noTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.update_ShipmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(772, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 28);
            this.label12.TabIndex = 64;
            this.label12.Text = "Consignment Number";
            // 
            // consignment_noTextBox
            // 
            this.consignment_noTextBox.Location = new System.Drawing.Point(777, 465);
            this.consignment_noTextBox.Name = "consignment_noTextBox";
            this.consignment_noTextBox.Size = new System.Drawing.Size(380, 49);
            this.consignment_noTextBox.TabIndex = 63;
            this.consignment_noTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(770, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 38);
            this.label2.TabIndex = 65;
            this.label2.Text = "Complete    Shipment";
            // 
            // update_ShipmentButton
            // 
            this.update_ShipmentButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.update_ShipmentButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_ShipmentButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.update_ShipmentButton.Location = new System.Drawing.Point(777, 545);
            this.update_ShipmentButton.Name = "update_ShipmentButton";
            this.update_ShipmentButton.Size = new System.Drawing.Size(380, 57);
            this.update_ShipmentButton.TabIndex = 66;
            this.update_ShipmentButton.Text = "Complete Shipment";
            this.update_ShipmentButton.UseVisualStyleBackColor = false;
            this.update_ShipmentButton.Click += new System.EventHandler(this.completeShipmentButtonCLk);
            // 
            // CompleteDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1841, 894);
            this.Controls.Add(this.update_ShipmentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.consignment_noTextBox);
            this.Name = "CompleteDelivery";
            this.Text = "CompleteDelivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox consignment_noTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_ShipmentButton;
    }
}