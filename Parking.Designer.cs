namespace ParkingApp
{
    partial class Parking
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
            this.btnPark = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlParking = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.lblCountPark = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPark
            // 
            this.btnPark.Location = new System.Drawing.Point(166, 229);
            this.btnPark.Name = "btnPark";
            this.btnPark.Size = new System.Drawing.Size(99, 39);
            this.btnPark.TabIndex = 0;
            this.btnPark.Text = "Park";
            this.btnPark.UseVisualStyleBackColor = true;
            this.btnPark.Click += new System.EventHandler(this.btnPark_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(442, 229);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(91, 39);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ddlType
            // 
            this.ddlType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Location = new System.Drawing.Point(210, 53);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(252, 33);
            this.ddlType.TabIndex = 2;
            this.ddlType.SelectedIndexChanged += new System.EventHandler(this.ddlType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehicle Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Available Parking :";
            // 
            // ddlParking
            // 
            this.ddlParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlParking.FormattingEnabled = true;
            this.ddlParking.Location = new System.Drawing.Point(210, 110);
            this.ddlParking.Name = "ddlParking";
            this.ddlParking.Size = new System.Drawing.Size(252, 33);
            this.ddlParking.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vehicle No :";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNo.Location = new System.Drawing.Point(210, 161);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(252, 30);
            this.txtVehicleNo.TabIndex = 7;
            // 
            // lblCountPark
            // 
            this.lblCountPark.AutoSize = true;
            this.lblCountPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountPark.Location = new System.Drawing.Point(468, 113);
            this.lblCountPark.Name = "lblCountPark";
            this.lblCountPark.Size = new System.Drawing.Size(103, 25);
            this.lblCountPark.TabIndex = 8;
            this.lblCountPark.Text = "Available :";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(577, 112);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 25);
            this.lblCount.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(304, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 334);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCountPark);
            this.Controls.Add(this.txtVehicleNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlParking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlType);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.btnPark);
            this.Name = "Parking";
            this.Text = "Parking Status";
            this.Load += new System.EventHandler(this.Parking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPark;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlParking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.Label lblCountPark;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnExit;
    }
}

