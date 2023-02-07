namespace Presentation_Layer
{
    partial class Frm_Route
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Route));
            this.routesDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header = new System.Windows.Forms.Panel();
            this.routeLBL = new System.Windows.Forms.Label();
            this.closeBTN = new System.Windows.Forms.PictureBox();
            this.routePanel = new System.Windows.Forms.Panel();
            this.delRouteBtn = new System.Windows.Forms.Button();
            this.editCbx = new System.Windows.Forms.CheckBox();
            this.codigoLbl = new System.Windows.Forms.Label();
            this.codigoTxt = new System.Windows.Forms.TextBox();
            this.codigoPBx = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.precioTxt = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.destinoTxt = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.origenTxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.routesDGV)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            this.routePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // routesDGV
            // 
            this.routesDGV.AllowUserToAddRows = false;
            this.routesDGV.AllowUserToDeleteRows = false;
            this.routesDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.routesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.routesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.routesDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.routesDGV.BackgroundColor = System.Drawing.Color.White;
            this.routesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.routesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.routesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.routesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.routesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.code,
            this.origin,
            this.destination,
            this.price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.routesDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.routesDGV.Location = new System.Drawing.Point(237, 35);
            this.routesDGV.MultiSelect = false;
            this.routesDGV.Name = "routesDGV";
            this.routesDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.routesDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.routesDGV.RowHeadersVisible = false;
            this.routesDGV.RowTemplate.Height = 25;
            this.routesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.routesDGV.Size = new System.Drawing.Size(563, 314);
            this.routesDGV.TabIndex = 21;
            this.routesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.routesDGV_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "RouteID";
            this.id.FillWeight = 40F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // code
            // 
            this.code.DataPropertyName = "RouteCode";
            this.code.FillWeight = 70F;
            this.code.HeaderText = "Código";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // origin
            // 
            this.origin.DataPropertyName = "Origin";
            this.origin.HeaderText = "Origen";
            this.origin.Name = "origin";
            this.origin.ReadOnly = true;
            // 
            // destination
            // 
            this.destination.DataPropertyName = "Destination";
            this.destination.HeaderText = "Destino";
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.Header.Controls.Add(this.routeLBL);
            this.Header.Controls.Add(this.closeBTN);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(800, 35);
            this.Header.TabIndex = 22;
            // 
            // routeLBL
            // 
            this.routeLBL.AutoSize = true;
            this.routeLBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.routeLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.routeLBL.ForeColor = System.Drawing.Color.White;
            this.routeLBL.Location = new System.Drawing.Point(0, 0);
            this.routeLBL.Name = "routeLBL";
            this.routeLBL.Size = new System.Drawing.Size(90, 32);
            this.routeLBL.TabIndex = 2;
            this.routeLBL.Text = "RUTA";
            this.routeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeBTN
            // 
            this.closeBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBTN.Image = ((System.Drawing.Image)(resources.GetObject("closeBTN.Image")));
            this.closeBTN.Location = new System.Drawing.Point(763, 0);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(37, 35);
            this.closeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBTN.TabIndex = 1;
            this.closeBTN.TabStop = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // routePanel
            // 
            this.routePanel.Controls.Add(this.delRouteBtn);
            this.routePanel.Controls.Add(this.editCbx);
            this.routePanel.Controls.Add(this.codigoLbl);
            this.routePanel.Controls.Add(this.codigoTxt);
            this.routePanel.Controls.Add(this.codigoPBx);
            this.routePanel.Controls.Add(this.label3);
            this.routePanel.Controls.Add(this.label2);
            this.routePanel.Controls.Add(this.label1);
            this.routePanel.Controls.Add(this.precioTxt);
            this.routePanel.Controls.Add(this.pictureBox5);
            this.routePanel.Controls.Add(this.destinoTxt);
            this.routePanel.Controls.Add(this.pictureBox3);
            this.routePanel.Controls.Add(this.origenTxt);
            this.routePanel.Controls.Add(this.pictureBox2);
            this.routePanel.Controls.Add(this.addBTN);
            this.routePanel.Controls.Add(this.editBTN);
            this.routePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.routePanel.ForeColor = System.Drawing.Color.Black;
            this.routePanel.Location = new System.Drawing.Point(0, 35);
            this.routePanel.Name = "routePanel";
            this.routePanel.Size = new System.Drawing.Size(238, 314);
            this.routePanel.TabIndex = 23;
            // 
            // delRouteBtn
            // 
            this.delRouteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delRouteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.delRouteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delRouteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delRouteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.delRouteBtn.Image = ((System.Drawing.Image)(resources.GetObject("delRouteBtn.Image")));
            this.delRouteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delRouteBtn.Location = new System.Drawing.Point(9, 258);
            this.delRouteBtn.Name = "delRouteBtn";
            this.delRouteBtn.Size = new System.Drawing.Size(102, 44);
            this.delRouteBtn.TabIndex = 31;
            this.delRouteBtn.Text = "Eliminar";
            this.delRouteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delRouteBtn.UseVisualStyleBackColor = false;
            this.delRouteBtn.Click += new System.EventHandler(this.delRouteBtn_Click);
            // 
            // editCbx
            // 
            this.editCbx.AutoSize = true;
            this.editCbx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.editCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.editCbx.Location = new System.Drawing.Point(9, 6);
            this.editCbx.Name = "editCbx";
            this.editCbx.Size = new System.Drawing.Size(99, 19);
            this.editCbx.TabIndex = 23;
            this.editCbx.Text = "Editar Ruta";
            this.editCbx.UseVisualStyleBackColor = true;
            this.editCbx.CheckedChanged += new System.EventHandler(this.editCbx_CheckedChanged);
            // 
            // codigoLbl
            // 
            this.codigoLbl.AutoSize = true;
            this.codigoLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codigoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.codigoLbl.Location = new System.Drawing.Point(9, 45);
            this.codigoLbl.Name = "codigoLbl";
            this.codigoLbl.Size = new System.Drawing.Size(49, 14);
            this.codigoLbl.TabIndex = 21;
            this.codigoLbl.Text = "Código";
            this.codigoLbl.Visible = false;
            // 
            // codigoTxt
            // 
            this.codigoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigoTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codigoTxt.Location = new System.Drawing.Point(19, 63);
            this.codigoTxt.Multiline = true;
            this.codigoTxt.Name = "codigoTxt";
            this.codigoTxt.Size = new System.Drawing.Size(185, 18);
            this.codigoTxt.TabIndex = 20;
            // 
            // codigoPBx
            // 
            this.codigoPBx.Image = ((System.Drawing.Image)(resources.GetObject("codigoPBx.Image")));
            this.codigoPBx.Location = new System.Drawing.Point(9, 56);
            this.codigoPBx.Name = "codigoPBx";
            this.codigoPBx.Size = new System.Drawing.Size(207, 27);
            this.codigoPBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.codigoPBx.TabIndex = 19;
            this.codigoPBx.TabStop = false;
            this.codigoPBx.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(9, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(9, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Origen";
            // 
            // precioTxt
            // 
            this.precioTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.precioTxt.Location = new System.Drawing.Point(19, 212);
            this.precioTxt.Multiline = true;
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(185, 18);
            this.precioTxt.TabIndex = 9;
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
            // destinoTxt
            // 
            this.destinoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.destinoTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destinoTxt.Location = new System.Drawing.Point(19, 161);
            this.destinoTxt.Multiline = true;
            this.destinoTxt.Name = "destinoTxt";
            this.destinoTxt.Size = new System.Drawing.Size(185, 18);
            this.destinoTxt.TabIndex = 5;
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
            // origenTxt
            // 
            this.origenTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.origenTxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.origenTxt.Location = new System.Drawing.Point(19, 110);
            this.origenTxt.Multiline = true;
            this.origenTxt.Name = "origenTxt";
            this.origenTxt.Size = new System.Drawing.Size(185, 18);
            this.origenTxt.TabIndex = 3;
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
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.addBTN.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.Image")));
            this.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBTN.Location = new System.Drawing.Point(113, 259);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(103, 43);
            this.addBTN.TabIndex = 18;
            this.addBTN.Text = "Agregar";
            this.addBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.editBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.editBTN.Image = ((System.Drawing.Image)(resources.GetObject("editBTN.Image")));
            this.editBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBTN.Location = new System.Drawing.Point(113, 259);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(103, 43);
            this.editBTN.TabIndex = 18;
            this.editBTN.Text = "Editar";
            this.editBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Visible = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // Frm_Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.routePanel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.routesDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Route";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Route_Load);
            ((System.ComponentModel.ISupportInitialize)(this.routesDGV)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            this.routePanel.ResumeLayout(false);
            this.routePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoPBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView routesDGV;
        private Panel Header;
        private Label routeLBL;
        private PictureBox closeBTN;
        private Panel routePanel;
        private CheckBox editCbx;
        private Label codigoLbl;
        private TextBox codigoTxt;
        private PictureBox codigoPBx;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox precioTxt;
        private PictureBox pictureBox5;
        private TextBox destinoTxt;
        private PictureBox pictureBox3;
        private TextBox origenTxt;
        private PictureBox pictureBox2;
        private Button addBTN;
        private Button editBTN;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn origin;
        private DataGridViewTextBoxColumn destination;
        private DataGridViewTextBoxColumn price;
        private Button delRouteBtn;
    }
}