namespace Presentation_Layer
{
    partial class Frm_Driver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Driver));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeBTN = new System.Windows.Forms.PictureBox();
            this.conductorLBL = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.editBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cedulaTxt = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.celularTxt = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.correoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fechNacDtp = new System.Windows.Forms.DateTimePicker();
            this.editCbx = new System.Windows.Forms.CheckBox();
            this.driver_Panel = new System.Windows.Forms.Panel();
            this.delDriverBtn = new System.Windows.Forms.Button();
            this.codigoTxt = new System.Windows.Forms.TextBox();
            this.codigoLbl = new System.Windows.Forms.Label();
            this.codigoPBx = new System.Windows.Forms.PictureBox();
            this.driversDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.driver_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBTN.Image = ((System.Drawing.Image)(resources.GetObject("closeBTN.Image")));
            this.closeBTN.Location = new System.Drawing.Point(915, 0);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(37, 35);
            this.closeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBTN.TabIndex = 1;
            this.closeBTN.TabStop = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // conductorLBL
            // 
            this.conductorLBL.AutoSize = true;
            this.conductorLBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.conductorLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conductorLBL.ForeColor = System.Drawing.Color.White;
            this.conductorLBL.Location = new System.Drawing.Point(0, 0);
            this.conductorLBL.Name = "conductorLBL";
            this.conductorLBL.Size = new System.Drawing.Size(194, 32);
            this.conductorLBL.TabIndex = 2;
            this.conductorLBL.Text = "CONDUCTOR";
            this.conductorLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.Header.Controls.Add(this.conductorLBL);
            this.Header.Controls.Add(this.closeBTN);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(952, 35);
            this.Header.TabIndex = 3;
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.editBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.editBTN.Image = ((System.Drawing.Image)(resources.GetObject("editBTN.Image")));
            this.editBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBTN.Location = new System.Drawing.Point(116, 388);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(103, 43);
            this.editBTN.TabIndex = 18;
            this.editBTN.Text = "Editar";
            this.editBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Visible = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.addBTN.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.Image")));
            this.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBTN.Location = new System.Drawing.Point(116, 388);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(103, 43);
            this.addBTN.TabIndex = 18;
            this.addBTN.Text = "Agregar";
            this.addBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // cedulaTxt
            // 
            this.cedulaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cedulaTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cedulaTxt.Location = new System.Drawing.Point(19, 110);
            this.cedulaTxt.Name = "cedulaTxt";
            this.cedulaTxt.Size = new System.Drawing.Size(185, 18);
            this.cedulaTxt.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 155);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(207, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // nombreTxt
            // 
            this.nombreTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreTxt.Location = new System.Drawing.Point(19, 161);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(185, 18);
            this.nombreTxt.TabIndex = 5;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 303);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(207, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // celularTxt
            // 
            this.celularTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.celularTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.celularTxt.Location = new System.Drawing.Point(22, 309);
            this.celularTxt.Name = "celularTxt";
            this.celularTxt.Size = new System.Drawing.Size(185, 18);
            this.celularTxt.TabIndex = 7;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(9, 206);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(207, 27);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apellidoTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apellidoTxt.Location = new System.Drawing.Point(19, 212);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(185, 18);
            this.apellidoTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(9, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cédula";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 355);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(207, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // correoTxt
            // 
            this.correoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correoTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correoTxt.Location = new System.Drawing.Point(22, 361);
            this.correoTxt.Name = "correoTxt";
            this.correoTxt.Size = new System.Drawing.Size(185, 18);
            this.correoTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(9, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(9, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(12, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(12, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Correo Electronico";
            // 
            // fechNacDtp
            // 
            this.fechNacDtp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechNacDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechNacDtp.Location = new System.Drawing.Point(9, 256);
            this.fechNacDtp.Margin = new System.Windows.Forms.Padding(0);
            this.fechNacDtp.Name = "fechNacDtp";
            this.fechNacDtp.Size = new System.Drawing.Size(210, 25);
            this.fechNacDtp.TabIndex = 17;
            this.fechNacDtp.Value = new System.DateTime(2022, 7, 28, 20, 49, 9, 0);
            // 
            // editCbx
            // 
            this.editCbx.AutoSize = true;
            this.editCbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.editCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.editCbx.Location = new System.Drawing.Point(9, 6);
            this.editCbx.Name = "editCbx";
            this.editCbx.Size = new System.Drawing.Size(138, 19);
            this.editCbx.TabIndex = 23;
            this.editCbx.Text = "Editar Conductor";
            this.editCbx.UseVisualStyleBackColor = true;
            this.editCbx.CheckedChanged += new System.EventHandler(this.editCbx_CheckedChanged);
            // 
            // driver_Panel
            // 
            this.driver_Panel.Controls.Add(this.delDriverBtn);
            this.driver_Panel.Controls.Add(this.codigoTxt);
            this.driver_Panel.Controls.Add(this.codigoLbl);
            this.driver_Panel.Controls.Add(this.editCbx);
            this.driver_Panel.Controls.Add(this.fechNacDtp);
            this.driver_Panel.Controls.Add(this.label6);
            this.driver_Panel.Controls.Add(this.label5);
            this.driver_Panel.Controls.Add(this.label4);
            this.driver_Panel.Controls.Add(this.label3);
            this.driver_Panel.Controls.Add(this.label2);
            this.driver_Panel.Controls.Add(this.correoTxt);
            this.driver_Panel.Controls.Add(this.pictureBox6);
            this.driver_Panel.Controls.Add(this.label1);
            this.driver_Panel.Controls.Add(this.apellidoTxt);
            this.driver_Panel.Controls.Add(this.pictureBox5);
            this.driver_Panel.Controls.Add(this.celularTxt);
            this.driver_Panel.Controls.Add(this.pictureBox4);
            this.driver_Panel.Controls.Add(this.nombreTxt);
            this.driver_Panel.Controls.Add(this.pictureBox3);
            this.driver_Panel.Controls.Add(this.cedulaTxt);
            this.driver_Panel.Controls.Add(this.pictureBox2);
            this.driver_Panel.Controls.Add(this.addBTN);
            this.driver_Panel.Controls.Add(this.editBTN);
            this.driver_Panel.Controls.Add(this.codigoPBx);
            this.driver_Panel.ForeColor = System.Drawing.Color.Black;
            this.driver_Panel.Location = new System.Drawing.Point(0, 35);
            this.driver_Panel.Name = "driver_Panel";
            this.driver_Panel.Size = new System.Drawing.Size(238, 443);
            this.driver_Panel.TabIndex = 2;
            // 
            // delDriverBtn
            // 
            this.delDriverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delDriverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.delDriverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delDriverBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delDriverBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.delDriverBtn.Image = ((System.Drawing.Image)(resources.GetObject("delDriverBtn.Image")));
            this.delDriverBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delDriverBtn.Location = new System.Drawing.Point(8, 388);
            this.delDriverBtn.Name = "delDriverBtn";
            this.delDriverBtn.Size = new System.Drawing.Size(102, 44);
            this.delDriverBtn.TabIndex = 31;
            this.delDriverBtn.Text = "Eliminar";
            this.delDriverBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delDriverBtn.UseVisualStyleBackColor = false;
            this.delDriverBtn.Click += new System.EventHandler(this.delDriverBtn_Click);
            // 
            // codigoTxt
            // 
            this.codigoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigoTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codigoTxt.Location = new System.Drawing.Point(19, 62);
            this.codigoTxt.Name = "codigoTxt";
            this.codigoTxt.Size = new System.Drawing.Size(185, 18);
            this.codigoTxt.TabIndex = 24;
            this.codigoTxt.Visible = false;
            // 
            // codigoLbl
            // 
            this.codigoLbl.AutoSize = true;
            this.codigoLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codigoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.codigoLbl.Location = new System.Drawing.Point(9, 44);
            this.codigoLbl.Name = "codigoLbl";
            this.codigoLbl.Size = new System.Drawing.Size(49, 14);
            this.codigoLbl.TabIndex = 25;
            this.codigoLbl.Text = "Código";
            this.codigoLbl.Visible = false;
            // 
            // codigoPBx
            // 
            this.codigoPBx.Image = ((System.Drawing.Image)(resources.GetObject("codigoPBx.Image")));
            this.codigoPBx.Location = new System.Drawing.Point(9, 55);
            this.codigoPBx.Name = "codigoPBx";
            this.codigoPBx.Size = new System.Drawing.Size(207, 27);
            this.codigoPBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.codigoPBx.TabIndex = 23;
            this.codigoPBx.TabStop = false;
            this.codigoPBx.Visible = false;
            // 
            // driversDGV
            // 
            this.driversDGV.AllowUserToAddRows = false;
            this.driversDGV.AllowUserToDeleteRows = false;
            this.driversDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driversDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.driversDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driversDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.driversDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.driversDGV.BackgroundColor = System.Drawing.Color.White;
            this.driversDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driversDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.driversDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driversDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.driversDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driversDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.code,
            this.cedula,
            this.firstName,
            this.lastName,
            this.birthdate,
            this.movil,
            this.email});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driversDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.driversDGV.Location = new System.Drawing.Point(222, 35);
            this.driversDGV.MultiSelect = false;
            this.driversDGV.Name = "driversDGV";
            this.driversDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.driversDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.driversDGV.RowHeadersVisible = false;
            this.driversDGV.RowTemplate.Height = 25;
            this.driversDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driversDGV.Size = new System.Drawing.Size(730, 443);
            this.driversDGV.TabIndex = 22;
            this.driversDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.driversDGV_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "DriverID";
            this.id.FillWeight = 40F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // code
            // 
            this.code.DataPropertyName = "DriverCode";
            this.code.FillWeight = 70F;
            this.code.HeaderText = "Código";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // cedula
            // 
            this.cedula.DataPropertyName = "Cedula";
            this.cedula.HeaderText = "Cédula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "FirstName";
            this.firstName.HeaderText = "Nombre";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "LastName";
            this.lastName.HeaderText = "Apellido";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // birthdate
            // 
            this.birthdate.DataPropertyName = "Birthdate";
            this.birthdate.HeaderText = "Fecha Nac";
            this.birthdate.Name = "birthdate";
            this.birthdate.ReadOnly = true;
            // 
            // movil
            // 
            this.movil.DataPropertyName = "Movil";
            this.movil.HeaderText = "Celular";
            this.movil.Name = "movil";
            this.movil.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Correo";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Frm_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 478);
            this.Controls.Add(this.driversDGV);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.driver_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Driver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.driver_Panel.ResumeLayout(false);
            this.driver_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox closeBTN;
        private Label conductorLBL;
        private Panel Header;
        private Button editBTN;
        private Button addBTN;
        private PictureBox pictureBox2;
        private TextBox cedulaTxt;
        private PictureBox pictureBox3;
        private TextBox nombreTxt;
        private PictureBox pictureBox4;
        private TextBox celularTxt;
        private PictureBox pictureBox5;
        private TextBox apellidoTxt;
        private Label label1;
        private PictureBox pictureBox6;
        private TextBox correoTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker fechNacDtp;
        private CheckBox editCbx;
        private Panel driver_Panel;
        private DataGridView driversDGV;
        private Label codigoLbl;
        private TextBox codigoTxt;
        private PictureBox codigoPBx;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn cedula;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn birthdate;
        private DataGridViewTextBoxColumn movil;
        private DataGridViewTextBoxColumn email;
        private Button delDriverBtn;
    }
}