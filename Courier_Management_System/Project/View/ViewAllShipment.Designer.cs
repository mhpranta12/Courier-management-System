
namespace Project.View
{
    partial class ViewAllShipment
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
            this.shipmentlistdataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insert_ShipmentButton = new System.Windows.Forms.Button();
            this.consignment_noTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentlistdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shipmentlistdataGridView
            // 
            this.shipmentlistdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipmentlistdataGridView.Location = new System.Drawing.Point(244, 340);
            this.shipmentlistdataGridView.Name = "shipmentlistdataGridView";
            this.shipmentlistdataGridView.RowHeadersWidth = 51;
            this.shipmentlistdataGridView.RowTemplate.Height = 24;
            this.shipmentlistdataGridView.Size = new System.Drawing.Size(1406, 703);
            this.shipmentlistdataGridView.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(789, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = " Shipment List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Consignment Number ";
            // 
            // insert_ShipmentButton
            // 
            this.insert_ShipmentButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insert_ShipmentButton.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_ShipmentButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.insert_ShipmentButton.Location = new System.Drawing.Point(244, 247);
            this.insert_ShipmentButton.Name = "insert_ShipmentButton";
            this.insert_ShipmentButton.Size = new System.Drawing.Size(247, 49);
            this.insert_ShipmentButton.TabIndex = 54;
            this.insert_ShipmentButton.Text = "Search";
            this.insert_ShipmentButton.UseVisualStyleBackColor = false;
            this.insert_ShipmentButton.Click += new System.EventHandler(this.serachButtonCLk);
            // 
            // consignment_noTextBox
            // 
            this.consignment_noTextBox.Location = new System.Drawing.Point(244, 165);
            this.consignment_noTextBox.Name = "consignment_noTextBox";
            this.consignment_noTextBox.Size = new System.Drawing.Size(380, 49);
            this.consignment_noTextBox.TabIndex = 53;
            this.consignment_noTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(664, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(834, 46);
            this.button1.TabIndex = 56;
            this.button1.Text = "View All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.viewListButtonCLk);
            // 
            // ViewAllShipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1839, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert_ShipmentButton);
            this.Controls.Add(this.consignment_noTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shipmentlistdataGridView);
            this.Name = "ViewAllShipment";
            this.Text = "ViewAllShipment";
            ((System.ComponentModel.ISupportInitialize)(this.shipmentlistdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView shipmentlistdataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insert_ShipmentButton;
        private System.Windows.Forms.RichTextBox consignment_noTextBox;
        private System.Windows.Forms.Button button1;
    }
}