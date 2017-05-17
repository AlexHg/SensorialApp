namespace WindowsFormsApp2
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
			this.header = new System.Windows.Forms.Panel();
			this.headerLogo = new ns1.BunifuImageButton();
			this.bunifuImageButton7 = new ns1.BunifuImageButton();
			this.bunifuImageButton6 = new ns1.BunifuImageButton();
			this.headerTitle = new ns1.BunifuCustomLabel();
			this.navigator = new System.Windows.Forms.Panel();
			this.navIndicator = new System.Windows.Forms.PictureBox();
			this.navHover = new System.Windows.Forms.PictureBox();
			this.bunifuImageButton2 = new ns1.BunifuImageButton();
			this.bunifuImageButton1 = new ns1.BunifuImageButton();
			this.bunifuImageButton3 = new ns1.BunifuImageButton();
			this.bunifuImageButton4 = new ns1.BunifuImageButton();
			this.bunifuImageButton5 = new ns1.BunifuImageButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.bunifuImageButton8 = new ns1.BunifuImageButton();
			this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
			this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
			this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
			this.bunifuCircleProgressbar1 = new ns1.BunifuCircleProgressbar();
			this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
			this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
			this.bunifuDragControl3 = new ns1.BunifuDragControl(this.components);
			this.container = new System.Windows.Forms.Panel();
			this.header.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.headerLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
			this.navigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.navIndicator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.navHover)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// header
			// 
			this.header.AllowDrop = true;
			this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
			this.header.Controls.Add(this.headerLogo);
			this.header.Controls.Add(this.bunifuImageButton7);
			this.header.Controls.Add(this.bunifuImageButton6);
			this.header.Controls.Add(this.headerTitle);
			this.header.Dock = System.Windows.Forms.DockStyle.Top;
			this.header.Location = new System.Drawing.Point(0, 0);
			this.header.Name = "header";
			this.header.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.header.Size = new System.Drawing.Size(1065, 42);
			this.header.TabIndex = 0;
			// 
			// headerLogo
			// 
			this.headerLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
			this.headerLogo.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.headerLogo.Image = ((System.Drawing.Image)(resources.GetObject("headerLogo.Image")));
			this.headerLogo.ImageActive = null;
			this.headerLogo.Location = new System.Drawing.Point(5, 4);
			this.headerLogo.Name = "headerLogo";
			this.headerLogo.Size = new System.Drawing.Size(39, 33);
			this.headerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.headerLogo.TabIndex = 7;
			this.headerLogo.TabStop = false;
			this.headerLogo.Zoom = 0;
			this.headerLogo.Click += new System.EventHandler(this.bunifuImageButton8_Click);
			// 
			// bunifuImageButton7
			// 
			this.bunifuImageButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
			this.bunifuImageButton7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton7.Dock = System.Windows.Forms.DockStyle.Right;
			this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
			this.bunifuImageButton7.ImageActive = null;
			this.bunifuImageButton7.Location = new System.Drawing.Point(995, 0);
			this.bunifuImageButton7.Name = "bunifuImageButton7";
			this.bunifuImageButton7.Size = new System.Drawing.Size(30, 42);
			this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton7.TabIndex = 9;
			this.bunifuImageButton7.TabStop = false;
			this.bunifuImageButton7.Zoom = 0;
			this.bunifuImageButton7.Click += new System.EventHandler(this.bunifuImageButton7_Click);
			// 
			// bunifuImageButton6
			// 
			this.bunifuImageButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
			this.bunifuImageButton6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton6.Dock = System.Windows.Forms.DockStyle.Right;
			this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
			this.bunifuImageButton6.ImageActive = null;
			this.bunifuImageButton6.Location = new System.Drawing.Point(1025, 0);
			this.bunifuImageButton6.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
			this.bunifuImageButton6.Name = "bunifuImageButton6";
			this.bunifuImageButton6.Padding = new System.Windows.Forms.Padding(30);
			this.bunifuImageButton6.Size = new System.Drawing.Size(30, 42);
			this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton6.TabIndex = 7;
			this.bunifuImageButton6.TabStop = false;
			this.bunifuImageButton6.Zoom = 0;
			this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
			// 
			// headerTitle
			// 
			this.headerTitle.AutoSize = true;
			this.headerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.headerTitle.Location = new System.Drawing.Point(52, 12);
			this.headerTitle.Name = "headerTitle";
			this.headerTitle.Size = new System.Drawing.Size(310, 18);
			this.headerTitle.TabIndex = 8;
			this.headerTitle.Text = "IPN Escuela Superior de Computo - Sensorial";
			// 
			// navigator
			// 
			this.navigator.BackColor = System.Drawing.Color.Black;
			this.navigator.Controls.Add(this.navIndicator);
			this.navigator.Controls.Add(this.navHover);
			this.navigator.Controls.Add(this.bunifuImageButton2);
			this.navigator.Controls.Add(this.bunifuImageButton1);
			this.navigator.Controls.Add(this.bunifuImageButton3);
			this.navigator.Controls.Add(this.bunifuImageButton4);
			this.navigator.Controls.Add(this.bunifuImageButton5);
			this.navigator.Dock = System.Windows.Forms.DockStyle.Left;
			this.navigator.Location = new System.Drawing.Point(0, 42);
			this.navigator.Name = "navigator";
			this.navigator.Padding = new System.Windows.Forms.Padding(13, 10, 13, 13);
			this.navigator.Size = new System.Drawing.Size(47, 502);
			this.navigator.TabIndex = 1;
			// 
			// navIndicator
			// 
			this.navIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
			this.navIndicator.Location = new System.Drawing.Point(-6, 10);
			this.navIndicator.Name = "navIndicator";
			this.navIndicator.Size = new System.Drawing.Size(11, 37);
			this.navIndicator.TabIndex = 3;
			this.navIndicator.TabStop = false;
			// 
			// navHover
			// 
			this.navHover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
			this.navHover.Location = new System.Drawing.Point(-6, -41);
			this.navHover.Name = "navHover";
			this.navHover.Size = new System.Drawing.Size(11, 37);
			this.navHover.TabIndex = 11;
			this.navHover.TabStop = false;
			// 
			// bunifuImageButton2
			// 
			this.bunifuImageButton2.BackColor = System.Drawing.Color.Black;
			this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Top;
			this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
			this.bunifuImageButton2.ImageActive = null;
			this.bunifuImageButton2.Location = new System.Drawing.Point(13, 158);
			this.bunifuImageButton2.Name = "bunifuImageButton2";
			this.bunifuImageButton2.Padding = new System.Windows.Forms.Padding(3);
			this.bunifuImageButton2.Size = new System.Drawing.Size(21, 37);
			this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton2.TabIndex = 9;
			this.bunifuImageButton2.TabStop = false;
			this.bunifuImageButton2.Zoom = 0;
			this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			this.bunifuImageButton2.MouseLeave += new System.EventHandler(this.bunifuImageButton5_MouseLeave);
			this.bunifuImageButton2.MouseHover += new System.EventHandler(this.bunifuImageButton5_MouseHover);
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.Black;
			this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Top;
			this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(13, 121);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(21, 37);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 8;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 0;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton2_Click);
			this.bunifuImageButton1.MouseLeave += new System.EventHandler(this.bunifuImageButton5_MouseLeave);
			this.bunifuImageButton1.MouseHover += new System.EventHandler(this.bunifuImageButton5_MouseHover);
			// 
			// bunifuImageButton3
			// 
			this.bunifuImageButton3.BackColor = System.Drawing.Color.Black;
			this.bunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton3.Dock = System.Windows.Forms.DockStyle.Top;
			this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
			this.bunifuImageButton3.ImageActive = null;
			this.bunifuImageButton3.Location = new System.Drawing.Point(13, 84);
			this.bunifuImageButton3.Name = "bunifuImageButton3";
			this.bunifuImageButton3.Size = new System.Drawing.Size(21, 37);
			this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton3.TabIndex = 5;
			this.bunifuImageButton3.TabStop = false;
			this.bunifuImageButton3.Zoom = 0;
			this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
			this.bunifuImageButton3.MouseLeave += new System.EventHandler(this.bunifuImageButton5_MouseLeave);
			this.bunifuImageButton3.MouseHover += new System.EventHandler(this.bunifuImageButton5_MouseHover);
			// 
			// bunifuImageButton4
			// 
			this.bunifuImageButton4.BackColor = System.Drawing.Color.Black;
			this.bunifuImageButton4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton4.Dock = System.Windows.Forms.DockStyle.Top;
			this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
			this.bunifuImageButton4.ImageActive = null;
			this.bunifuImageButton4.Location = new System.Drawing.Point(13, 47);
			this.bunifuImageButton4.Name = "bunifuImageButton4";
			this.bunifuImageButton4.Size = new System.Drawing.Size(21, 37);
			this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton4.TabIndex = 6;
			this.bunifuImageButton4.TabStop = false;
			this.bunifuImageButton4.Zoom = 0;
			this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
			this.bunifuImageButton4.MouseLeave += new System.EventHandler(this.bunifuImageButton5_MouseLeave);
			this.bunifuImageButton4.MouseHover += new System.EventHandler(this.bunifuImageButton5_MouseHover);
			// 
			// bunifuImageButton5
			// 
			this.bunifuImageButton5.BackColor = System.Drawing.Color.Black;
			this.bunifuImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton5.Dock = System.Windows.Forms.DockStyle.Top;
			this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
			this.bunifuImageButton5.ImageActive = null;
			this.bunifuImageButton5.Location = new System.Drawing.Point(13, 10);
			this.bunifuImageButton5.Margin = new System.Windows.Forms.Padding(5);
			this.bunifuImageButton5.Name = "bunifuImageButton5";
			this.bunifuImageButton5.Size = new System.Drawing.Size(21, 37);
			this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton5.TabIndex = 10;
			this.bunifuImageButton5.TabStop = false;
			this.bunifuImageButton5.Zoom = 0;
			this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
			this.bunifuImageButton5.MouseLeave += new System.EventHandler(this.bunifuImageButton5_MouseLeave);
			this.bunifuImageButton5.MouseHover += new System.EventHandler(this.bunifuImageButton5_MouseHover);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
			this.panel3.Controls.Add(this.bunifuImageButton8);
			this.panel3.Controls.Add(this.bunifuCustomLabel3);
			this.panel3.Controls.Add(this.bunifuCustomLabel4);
			this.panel3.Controls.Add(this.bunifuCustomLabel1);
			this.panel3.Controls.Add(this.bunifuCircleProgressbar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(47, 42);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1018, 136);
			this.panel3.TabIndex = 2;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// bunifuImageButton8
			// 
			this.bunifuImageButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
			this.bunifuImageButton8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton8.Image")));
			this.bunifuImageButton8.ImageActive = null;
			this.bunifuImageButton8.Location = new System.Drawing.Point(40, 41);
			this.bunifuImageButton8.Margin = new System.Windows.Forms.Padding(5);
			this.bunifuImageButton8.Name = "bunifuImageButton8";
			this.bunifuImageButton8.Size = new System.Drawing.Size(51, 45);
			this.bunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton8.TabIndex = 11;
			this.bunifuImageButton8.TabStop = false;
			this.bunifuImageButton8.Zoom = 15;
			this.bunifuImageButton8.Click += new System.EventHandler(this.bunifuImageButton8_Click_1);
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.AutoSize = true;
			this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(127, 20);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(288, 37);
			this.bunifuCustomLabel3.TabIndex = 3;
			this.bunifuCustomLabel3.Text = "GUI para tu sensor";
			this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
			// 
			// bunifuCustomLabel4
			// 
			this.bunifuCustomLabel4.AutoSize = true;
			this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.GreenYellow;
			this.bunifuCustomLabel4.Location = new System.Drawing.Point(263, 61);
			this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
			this.bunifuCustomLabel4.Size = new System.Drawing.Size(81, 18);
			this.bunifuCustomLabel4.TabIndex = 2;
			this.bunifuCustomLabel4.Text = "Conectado";
			this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGray;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(136, 61);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(136, 18);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Estado del sensor: ";
			this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click_1);
			// 
			// bunifuCircleProgressbar1
			// 
			this.bunifuCircleProgressbar1.animated = true;
			this.bunifuCircleProgressbar1.animationIterval = 5;
			this.bunifuCircleProgressbar1.animationSpeed = 100;
			this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
			this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
			this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
			this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
			this.bunifuCircleProgressbar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bunifuCircleProgressbar1.LabelVisible = false;
			this.bunifuCircleProgressbar1.LineProgressThickness = 5;
			this.bunifuCircleProgressbar1.LineThickness = 2;
			this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(13, 12);
			this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.bunifuCircleProgressbar1.MaxValue = 100;
			this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
			this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
			this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
			this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(103, 103);
			this.bunifuCircleProgressbar1.TabIndex = 0;
			this.bunifuCircleProgressbar1.Value = 60;
			// 
			// bunifuDragControl1
			// 
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.header;
			this.bunifuDragControl1.Vertical = true;
			// 
			// bunifuDragControl2
			// 
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.headerTitle;
			this.bunifuDragControl2.Vertical = true;
			// 
			// bunifuDragControl3
			// 
			this.bunifuDragControl3.Fixed = true;
			this.bunifuDragControl3.Horizontal = true;
			this.bunifuDragControl3.TargetControl = this.headerLogo;
			this.bunifuDragControl3.Vertical = true;
			// 
			// container
			// 
			this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
			this.container.Location = new System.Drawing.Point(47, 177);
			this.container.Name = "container";
			this.container.Size = new System.Drawing.Size(1015, 367);
			this.container.TabIndex = 3;
			this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(1065, 544);
			this.Controls.Add(this.container);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.navigator);
			this.Controls.Add(this.header);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.header.ResumeLayout(false);
			this.header.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.headerLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
			this.navigator.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.navIndicator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.navHover)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ns1.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.Panel navigator;
		private System.Windows.Forms.Panel header;
		private System.Windows.Forms.Panel panel3;
		private ns1.BunifuCustomLabel headerTitle;
		private ns1.BunifuImageButton bunifuImageButton6;
		private ns1.BunifuImageButton bunifuImageButton7;
		private ns1.BunifuDragControl bunifuDragControl1;
		private ns1.BunifuImageButton headerLogo;
		private ns1.BunifuCircleProgressbar bunifuCircleProgressbar1;
		private ns1.BunifuCustomLabel bunifuCustomLabel1;
		private ns1.BunifuCustomLabel bunifuCustomLabel4;
		private ns1.BunifuDragControl bunifuDragControl2;
		private ns1.BunifuDragControl bunifuDragControl3;
		private ns1.BunifuCustomLabel bunifuCustomLabel3;
		private ns1.BunifuImageButton bunifuImageButton3;
		private ns1.BunifuImageButton bunifuImageButton4;
		private ns1.BunifuImageButton bunifuImageButton2;
		private ns1.BunifuImageButton bunifuImageButton1;
		private ns1.BunifuImageButton bunifuImageButton5;
		private System.Windows.Forms.PictureBox navIndicator;
		private System.Windows.Forms.PictureBox navHover;
		private ns1.BunifuImageButton bunifuImageButton8;
		private System.Windows.Forms.Panel container;
	}
}

