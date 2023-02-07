namespace Presentation_Layer
{
    partial class Frm_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header = new System.Windows.Forms.Panel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.closeBTN = new System.Windows.Forms.PictureBox();
            this.driverBtn = new System.Windows.Forms.Button();
            this.routeBtn = new System.Windows.Forms.Button();
            this.busBtn = new System.Windows.Forms.Button();
            this.addTripBtn = new System.Windows.Forms.Button();
            this.delTripBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDGV
            // 
            this.mainDGV.AllowUserToAddRows = false;
            this.mainDGV.AllowUserToDeleteRows = false;
            this.mainDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mainDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainDGV.BackgroundColor = System.Drawing.Color.White;
            this.mainDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.mainDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.driver,
            this.bus,
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
            this.mainDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.mainDGV.Location = new System.Drawing.Point(0, 35);
            this.mainDGV.MultiSelect = false;
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            this.mainDGV.RowHeadersVisible = false;
            this.mainDGV.RowTemplate.Height = 25;
            this.mainDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDGV.Size = new System.Drawing.Size(809, 301);
            this.mainDGV.TabIndex = 21;
            // 
            // code
            // 
            this.code.DataPropertyName = "TripCode";
            this.code.HeaderText = "Código";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // driver
            // 
            this.driver.DataPropertyName = "DriverFullName";
            this.driver.HeaderText = "Conductor";
            this.driver.Name = "driver";
            this.driver.ReadOnly = true;
            // 
            // bus
            // 
            this.bus.DataPropertyName = "Bus";
            this.bus.HeaderText = "Autobus";
            this.bus.Name = "bus";
            this.bus.ReadOnly = true;
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
            this.Header.Controls.Add(this.headerLbl);
            this.Header.Controls.Add(this.closeBTN);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(809, 35);
            this.Header.TabIndex = 24;
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(0, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(373, 32);
            this.headerLbl.TabIndex = 2;
            this.headerLbl.Text = "CONTROL DE AUTOBUSES";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeBTN
            // 
            this.closeBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBTN.Image = ((System.Drawing.Image)(resources.GetObject("closeBTN.Image")));
            this.closeBTN.Location = new System.Drawing.Point(772, 0);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(37, 35);
            this.closeBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBTN.TabIndex = 1;
            this.closeBTN.TabStop = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // driverBtn
            // 
            this.driverBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.driverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.driverBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.driverBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.driverBtn.Location = new System.Drawing.Point(142, 342);
            this.driverBtn.Name = "driverBtn";
            this.driverBtn.Size = new System.Drawing.Size(124, 44);
            this.driverBtn.TabIndex = 27;
            this.driverBtn.Text = "Conductores";
            this.driverBtn.UseVisualStyleBackColor = false;
            this.driverBtn.Click += new System.EventHandler(this.driverBtn_Click);
            // 
            // routeBtn
            // 
            this.routeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.routeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.routeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.routeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.routeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.routeBtn.Location = new System.Drawing.Point(12, 342);
            this.routeBtn.Name = "routeBtn";
            this.routeBtn.Size = new System.Drawing.Size(124, 44);
            this.routeBtn.TabIndex = 26;
            this.routeBtn.Text = "Rutas";
            this.routeBtn.UseVisualStyleBackColor = false;
            this.routeBtn.Click += new System.EventHandler(this.routeBtn_Click);
            // 
            // busBtn
            // 
            this.busBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.busBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.busBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.busBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.busBtn.Location = new System.Drawing.Point(272, 342);
            this.busBtn.Name = "busBtn";
            this.busBtn.Size = new System.Drawing.Size(124, 44);
            this.busBtn.TabIndex = 25;
            this.busBtn.Text = "Autobuses";
            this.busBtn.UseVisualStyleBackColor = false;
            this.busBtn.Click += new System.EventHandler(this.busBtn_Click);
            // 
            // addTripBtn
            // 
            this.addTripBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTripBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.addTripBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTripBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTripBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.addTripBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTripBtn.Location = new System.Drawing.Point(402, 342);
            this.addTripBtn.Name = "addTripBtn";
            this.addTripBtn.Size = new System.Drawing.Size(124, 44);
            this.addTripBtn.TabIndex = 28;
            this.addTripBtn.Text = "Viajes";
            this.addTripBtn.UseVisualStyleBackColor = false;
            this.addTripBtn.Click += new System.EventHandler(this.addTripBtn_Click);
            // 
            // delTripBtn
            // 
            this.delTripBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delTripBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.delTripBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delTripBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delTripBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.delTripBtn.Image = ((System.Drawing.Image)(resources.GetObject("delTripBtn.Image")));
            this.delTripBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delTripBtn.Location = new System.Drawing.Point(683, 342);
            this.delTripBtn.Name = "delTripBtn";
            this.delTripBtn.Size = new System.Drawing.Size(114, 44);
            this.delTripBtn.TabIndex = 29;
            this.delTripBtn.Text = "Eliminar";
            this.delTripBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delTripBtn.UseVisualStyleBackColor = false;
            this.delTripBtn.Click += new System.EventHandler(this.delTripBtn_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 390);
            this.Controls.Add(this.delTripBtn);
            this.Controls.Add(this.addTripBtn);
            this.Controls.Add(this.driverBtn);
            this.Controls.Add(this.routeBtn);
            this.Controls.Add(this.busBtn);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.mainDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView mainDGV;
        private Panel Header;
        private Label headerLbl;
        private PictureBox closeBTN;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn driver;
        private DataGridViewTextBoxColumn bus;
        private DataGridViewTextBoxColumn origin;
        private DataGridViewTextBoxColumn destination;
        private DataGridViewTextBoxColumn price;
        private Button driverBtn;
        private Button routeBtn;
        private Button busBtn;
        private Button addTripBtn;
        private Button delTripBtn;
    }
}