namespace WinFormsDataCollector
{
    partial class DataCollector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            lblShipFrom = new Label();
            txtShipFrom = new TextBox();
            lblShipTo = new Label();
            txtShipTo = new TextBox();
            lblHelloWorld = new Label();
            groupBox1 = new GroupBox();
            lblSerialNumber = new Label();
            txtSerialNumber = new TextBox();
            lblSuplierCode = new Label();
            txtSuplierCode = new TextBox();
            lblSuplier = new Label();
            txtSuplier = new TextBox();
            lblHeat = new Label();
            txtHeat = new TextBox();
            lblLicensePlate = new Label();
            txtLicensePlate = new TextBox();
            lblPlant = new Label();
            txtPlant = new TextBox();
            lblMfgDate = new Label();
            txtMfgDate = new TextBox();
            lblLotNo = new Label();
            txtLotNo = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblPoNo = new Label();
            txtPoNo = new TextBox();
            lblRev = new Label();
            txtRev = new TextBox();
            lblPartNumber = new Label();
            txtPartNumber = new TextBox();
            txtDescription = new TextBox();
            lblDescription = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(67, 495);
            btnSubmit.Margin = new Padding(4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(96, 31);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += submitButton_Click;
            // 
            // lblShipFrom
            // 
            lblShipFrom.BorderStyle = BorderStyle.Fixed3D;
            lblShipFrom.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblShipFrom.Location = new Point(8, 20);
            lblShipFrom.Margin = new Padding(4, 0, 4, 0);
            lblShipFrom.Name = "lblShipFrom";
            lblShipFrom.Size = new Size(193, 27);
            lblShipFrom.TabIndex = 2;
            lblShipFrom.Text = "SHIP FROM:";
            lblShipFrom.TextAlign = ContentAlignment.MiddleLeft;
            lblShipFrom.Click += label1_Click;
            // 
            // txtShipFrom
            // 
            txtShipFrom.BorderStyle = BorderStyle.FixedSingle;
            txtShipFrom.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtShipFrom.Location = new Point(8, 48);
            txtShipFrom.Margin = new Padding(4);
            txtShipFrom.Multiline = true;
            txtShipFrom.Name = "txtShipFrom";
            txtShipFrom.Size = new Size(192, 66);
            txtShipFrom.TabIndex = 1;
            txtShipFrom.TabStop = false;
            txtShipFrom.TextChanged += shipToText_TextChanged;
            // 
            // lblShipTo
            // 
            lblShipTo.BorderStyle = BorderStyle.Fixed3D;
            lblShipTo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblShipTo.Location = new Point(208, 20);
            lblShipTo.Margin = new Padding(4, 0, 4, 0);
            lblShipTo.Name = "lblShipTo";
            lblShipTo.Size = new Size(193, 27);
            lblShipTo.TabIndex = 3;
            lblShipTo.Text = "SHIP TO:";
            lblShipTo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtShipTo
            // 
            txtShipTo.BorderStyle = BorderStyle.FixedSingle;
            txtShipTo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtShipTo.Location = new Point(208, 48);
            txtShipTo.Margin = new Padding(4);
            txtShipTo.Multiline = true;
            txtShipTo.Name = "txtShipTo";
            txtShipTo.Size = new Size(192, 66);
            txtShipTo.TabIndex = 4;
            txtShipTo.TabStop = false;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.BorderStyle = BorderStyle.FixedSingle;
            lblHelloWorld.Location = new Point(44, 456);
            lblHelloWorld.Margin = new Padding(3);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(534, 31);
            lblHelloWorld.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSerialNumber);
            groupBox1.Controls.Add(txtSerialNumber);
            groupBox1.Controls.Add(lblSuplierCode);
            groupBox1.Controls.Add(txtSuplierCode);
            groupBox1.Controls.Add(lblSuplier);
            groupBox1.Controls.Add(txtSuplier);
            groupBox1.Controls.Add(lblHeat);
            groupBox1.Controls.Add(txtHeat);
            groupBox1.Controls.Add(lblLicensePlate);
            groupBox1.Controls.Add(txtLicensePlate);
            groupBox1.Controls.Add(lblPlant);
            groupBox1.Controls.Add(txtPlant);
            groupBox1.Controls.Add(lblMfgDate);
            groupBox1.Controls.Add(txtMfgDate);
            groupBox1.Controls.Add(lblLotNo);
            groupBox1.Controls.Add(txtLotNo);
            groupBox1.Controls.Add(lblQuantity);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(lblPoNo);
            groupBox1.Controls.Add(txtPoNo);
            groupBox1.Controls.Add(lblRev);
            groupBox1.Controls.Add(txtRev);
            groupBox1.Controls.Add(lblPartNumber);
            groupBox1.Controls.Add(txtPartNumber);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(lblDescription);
            groupBox1.Controls.Add(txtShipTo);
            groupBox1.Controls.Add(lblShipTo);
            groupBox1.Controls.Add(lblShipFrom);
            groupBox1.Controls.Add(txtShipFrom);
            groupBox1.Location = new Point(44, 16);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1022, 433);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // lblSerialNumber
            // 
            lblSerialNumber.BorderStyle = BorderStyle.Fixed3D;
            lblSerialNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblSerialNumber.Location = new Point(409, 308);
            lblSerialNumber.Margin = new Padding(4, 0, 4, 0);
            lblSerialNumber.Name = "lblSerialNumber";
            lblSerialNumber.Size = new Size(594, 27);
            lblSerialNumber.TabIndex = 30;
            lblSerialNumber.Text = "MSM Serial #:";
            lblSerialNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.BorderStyle = BorderStyle.FixedSingle;
            txtSerialNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtSerialNumber.Location = new Point(409, 336);
            txtSerialNumber.Margin = new Padding(4);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(593, 27);
            txtSerialNumber.TabIndex = 29;
            // 
            // lblSuplierCode
            // 
            lblSuplierCode.BorderStyle = BorderStyle.Fixed3D;
            lblSuplierCode.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblSuplierCode.Location = new Point(8, 308);
            lblSuplierCode.Margin = new Padding(4, 0, 4, 0);
            lblSuplierCode.Name = "lblSuplierCode";
            lblSuplierCode.Size = new Size(393, 27);
            lblSuplierCode.TabIndex = 28;
            lblSuplierCode.Text = "Suplier Code:(V)";
            lblSuplierCode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSuplierCode
            // 
            txtSuplierCode.BorderStyle = BorderStyle.FixedSingle;
            txtSuplierCode.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtSuplierCode.Location = new Point(8, 336);
            txtSuplierCode.Margin = new Padding(4);
            txtSuplierCode.Name = "txtSuplierCode";
            txtSuplierCode.Size = new Size(393, 27);
            txtSuplierCode.TabIndex = 27;
            // 
            // lblSuplier
            // 
            lblSuplier.BorderStyle = BorderStyle.Fixed3D;
            lblSuplier.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblSuplier.Location = new Point(609, 245);
            lblSuplier.Margin = new Padding(4, 0, 4, 0);
            lblSuplier.Name = "lblSuplier";
            lblSuplier.Size = new Size(393, 27);
            lblSuplier.TabIndex = 26;
            lblSuplier.Text = "Suplier P#:";
            lblSuplier.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSuplier
            // 
            txtSuplier.BorderStyle = BorderStyle.FixedSingle;
            txtSuplier.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtSuplier.Location = new Point(609, 273);
            txtSuplier.Margin = new Padding(4);
            txtSuplier.Name = "txtSuplier";
            txtSuplier.Size = new Size(393, 27);
            txtSuplier.TabIndex = 25;
            // 
            // lblHeat
            // 
            lblHeat.BorderStyle = BorderStyle.Fixed3D;
            lblHeat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblHeat.Location = new Point(409, 245);
            lblHeat.Margin = new Padding(4, 0, 4, 0);
            lblHeat.Name = "lblHeat";
            lblHeat.Size = new Size(193, 27);
            lblHeat.TabIndex = 24;
            lblHeat.Text = "Heat:";
            lblHeat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHeat
            // 
            txtHeat.BorderStyle = BorderStyle.FixedSingle;
            txtHeat.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtHeat.Location = new Point(409, 273);
            txtHeat.Margin = new Padding(4);
            txtHeat.Name = "txtHeat";
            txtHeat.Size = new Size(192, 27);
            txtHeat.TabIndex = 23;
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.BorderStyle = BorderStyle.Fixed3D;
            lblLicensePlate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblLicensePlate.Location = new Point(8, 245);
            lblLicensePlate.Margin = new Padding(4, 0, 4, 0);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(393, 27);
            lblLicensePlate.TabIndex = 22;
            lblLicensePlate.Text = "License Plate:(1J)";
            lblLicensePlate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.BorderStyle = BorderStyle.FixedSingle;
            txtLicensePlate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtLicensePlate.Location = new Point(8, 273);
            txtLicensePlate.Margin = new Padding(4);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(393, 27);
            txtLicensePlate.TabIndex = 21;
            // 
            // lblPlant
            // 
            lblPlant.BorderStyle = BorderStyle.Fixed3D;
            lblPlant.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblPlant.Location = new Point(810, 183);
            lblPlant.Margin = new Padding(4, 0, 4, 0);
            lblPlant.Name = "lblPlant";
            lblPlant.Size = new Size(193, 27);
            lblPlant.TabIndex = 20;
            lblPlant.Text = "Plant:(2IL)";
            lblPlant.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPlant
            // 
            txtPlant.BorderStyle = BorderStyle.FixedSingle;
            txtPlant.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtPlant.Location = new Point(810, 211);
            txtPlant.Margin = new Padding(4);
            txtPlant.Name = "txtPlant";
            txtPlant.Size = new Size(192, 27);
            txtPlant.TabIndex = 19;
            // 
            // lblMfgDate
            // 
            lblMfgDate.BorderStyle = BorderStyle.Fixed3D;
            lblMfgDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblMfgDate.Location = new Point(609, 183);
            lblMfgDate.Margin = new Padding(4, 0, 4, 0);
            lblMfgDate.Name = "lblMfgDate";
            lblMfgDate.Size = new Size(193, 27);
            lblMfgDate.TabIndex = 18;
            lblMfgDate.Text = "Mfg Date:";
            lblMfgDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMfgDate
            // 
            txtMfgDate.BorderStyle = BorderStyle.FixedSingle;
            txtMfgDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtMfgDate.Location = new Point(609, 211);
            txtMfgDate.Margin = new Padding(4);
            txtMfgDate.Name = "txtMfgDate";
            txtMfgDate.Size = new Size(192, 27);
            txtMfgDate.TabIndex = 17;
            // 
            // lblLotNo
            // 
            lblLotNo.BorderStyle = BorderStyle.Fixed3D;
            lblLotNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblLotNo.Location = new Point(409, 183);
            lblLotNo.Margin = new Padding(4, 0, 4, 0);
            lblLotNo.Name = "lblLotNo";
            lblLotNo.Size = new Size(193, 27);
            lblLotNo.TabIndex = 16;
            lblLotNo.Text = "LOT#:(T)";
            lblLotNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLotNo
            // 
            txtLotNo.BorderStyle = BorderStyle.FixedSingle;
            txtLotNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtLotNo.Location = new Point(409, 211);
            txtLotNo.Margin = new Padding(4);
            txtLotNo.Name = "txtLotNo";
            txtLotNo.Size = new Size(192, 27);
            txtLotNo.TabIndex = 15;
            // 
            // lblQuantity
            // 
            lblQuantity.BorderStyle = BorderStyle.Fixed3D;
            lblQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblQuantity.Location = new Point(8, 183);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(393, 27);
            lblQuantity.TabIndex = 14;
            lblQuantity.Text = "Quantity:(Q)";
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtQuantity.Location = new Point(8, 211);
            txtQuantity.Margin = new Padding(4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(393, 27);
            txtQuantity.TabIndex = 13;
            // 
            // lblPoNo
            // 
            lblPoNo.BorderStyle = BorderStyle.Fixed3D;
            lblPoNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblPoNo.Location = new Point(810, 120);
            lblPoNo.Margin = new Padding(4, 0, 4, 0);
            lblPoNo.Name = "lblPoNo";
            lblPoNo.Size = new Size(193, 27);
            lblPoNo.TabIndex = 12;
            lblPoNo.Text = "PO No:(K)";
            lblPoNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPoNo
            // 
            txtPoNo.BorderStyle = BorderStyle.FixedSingle;
            txtPoNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtPoNo.Location = new Point(810, 148);
            txtPoNo.Margin = new Padding(4);
            txtPoNo.Name = "txtPoNo";
            txtPoNo.Size = new Size(192, 27);
            txtPoNo.TabIndex = 11;
            // 
            // lblRev
            // 
            lblRev.BorderStyle = BorderStyle.Fixed3D;
            lblRev.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblRev.Location = new Point(609, 120);
            lblRev.Margin = new Padding(4, 0, 4, 0);
            lblRev.Name = "lblRev";
            lblRev.Size = new Size(193, 27);
            lblRev.TabIndex = 10;
            lblRev.Text = "Rev Lvl:®";
            lblRev.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRev
            // 
            txtRev.BorderStyle = BorderStyle.FixedSingle;
            txtRev.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtRev.Location = new Point(609, 148);
            txtRev.Margin = new Padding(4);
            txtRev.Name = "txtRev";
            txtRev.Size = new Size(192, 27);
            txtRev.TabIndex = 9;
            // 
            // lblPartNumber
            // 
            lblPartNumber.BorderStyle = BorderStyle.Fixed3D;
            lblPartNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblPartNumber.Location = new Point(8, 120);
            lblPartNumber.Margin = new Padding(4, 0, 4, 0);
            lblPartNumber.Name = "lblPartNumber";
            lblPartNumber.Size = new Size(594, 27);
            lblPartNumber.TabIndex = 8;
            lblPartNumber.Text = "Part Number:(P)";
            lblPartNumber.TextAlign = ContentAlignment.MiddleLeft;
            lblPartNumber.Click += label1_Click_1;
            // 
            // txtPartNumber
            // 
            txtPartNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPartNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtPartNumber.Location = new Point(8, 148);
            txtPartNumber.Margin = new Padding(4);
            txtPartNumber.Name = "txtPartNumber";
            txtPartNumber.Size = new Size(593, 27);
            txtPartNumber.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtDescription.Location = new Point(409, 48);
            txtDescription.Margin = new Padding(4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(192, 27);
            txtDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.BorderStyle = BorderStyle.Fixed3D;
            lblDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblDescription.Location = new Point(409, 20);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(193, 27);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "DESCRIPTION";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 667);
            Controls.Add(groupBox1);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnSubmit);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "BarCode Generator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Button btnSubmit;
        private TextBox txtShipFrom;
        private Label lblShipFrom;
        private Label lblHelloWorld;
        private GroupBox groupBox1;
        private Label lblShipTo;
        private TextBox txtShipTo;
        private TextBox txtDescription;
        private Label lblDescription;
        private Label lblPartNumber;
        private TextBox txtPartNumber;
        private Label lblRev;
        private TextBox txtRev;
        private Label lblPoNo;
        private TextBox txtPoNo;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblLotNo;
        private TextBox txtLotNo;
        private Label lblMfgDate;
        private TextBox txtMfgDate;
        private Label lblPlant;
        private TextBox txtPlant;
        private Label lblLicensePlate;
        private TextBox txtLicensePlate;
        private Label lblHeat;
        private TextBox txtHeat;
        private Label lblSuplier;
        private TextBox txtSuplier;
        private Label lblSuplierCode;
        private TextBox txtSuplierCode;
        private Label lblSerialNumber;
        private TextBox txtSerialNumber;
    }
}
