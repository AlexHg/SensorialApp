namespace sensorial
{
	partial class tab_home
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

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
			this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
			this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
			this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
			this.bunifuSwitch4 = new ns1.BunifuSwitch();
			this.bunifuSwitch3 = new ns1.BunifuSwitch();
			this.bunifuSwitch2 = new ns1.BunifuSwitch();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cartesianChart1
			// 
			this.cartesianChart1.Location = new System.Drawing.Point(342, 45);
			this.cartesianChart1.Name = "cartesianChart1";
			this.cartesianChart1.Size = new System.Drawing.Size(649, 272);
			this.cartesianChart1.TabIndex = 19;
			this.cartesianChart1.Text = "cartesianChart1";
			this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged_1);
			// 
			// bunifuCustomLabel7
			// 
			this.bunifuCustomLabel7.AutoSize = true;
			this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bunifuCustomLabel7.Location = new System.Drawing.Point(27, 45);
			this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
			this.bunifuCustomLabel7.Size = new System.Drawing.Size(286, 31);
			this.bunifuCustomLabel7.TabIndex = 18;
			this.bunifuCustomLabel7.Text = "Administracion de leds";
			// 
			// bunifuCustomLabel6
			// 
			this.bunifuCustomLabel6.AutoSize = true;
			this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bunifuCustomLabel6.Location = new System.Drawing.Point(46, 177);
			this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
			this.bunifuCustomLabel6.Size = new System.Drawing.Size(76, 18);
			this.bunifuCustomLabel6.TabIndex = 17;
			this.bunifuCustomLabel6.Text = "Led toggle";
			// 
			// bunifuCustomLabel5
			// 
			this.bunifuCustomLabel5.AutoSize = true;
			this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bunifuCustomLabel5.Location = new System.Drawing.Point(46, 138);
			this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
			this.bunifuCustomLabel5.Size = new System.Drawing.Size(100, 18);
			this.bunifuCustomLabel5.TabIndex = 16;
			this.bunifuCustomLabel5.Text = "Led color rojo";
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(46, 97);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(110, 18);
			this.bunifuCustomLabel2.TabIndex = 15;
			this.bunifuCustomLabel2.Text = "Led color verde";
			// 
			// bunifuSwitch4
			// 
			this.bunifuSwitch4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuSwitch4.BorderRadius = 0;
			this.bunifuSwitch4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuSwitch4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuSwitch4.Location = new System.Drawing.Point(164, 177);
			this.bunifuSwitch4.Name = "bunifuSwitch4";
			this.bunifuSwitch4.Oncolor = System.Drawing.Color.SeaGreen;
			this.bunifuSwitch4.Onoffcolor = System.Drawing.Color.DarkGray;
			this.bunifuSwitch4.Size = new System.Drawing.Size(51, 19);
			this.bunifuSwitch4.TabIndex = 14;
			this.bunifuSwitch4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuSwitch4.Value = true;
			// 
			// bunifuSwitch3
			// 
			this.bunifuSwitch3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuSwitch3.BorderRadius = 0;
			this.bunifuSwitch3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuSwitch3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuSwitch3.Location = new System.Drawing.Point(164, 138);
			this.bunifuSwitch3.Name = "bunifuSwitch3";
			this.bunifuSwitch3.Oncolor = System.Drawing.Color.SeaGreen;
			this.bunifuSwitch3.Onoffcolor = System.Drawing.Color.DarkGray;
			this.bunifuSwitch3.Size = new System.Drawing.Size(51, 19);
			this.bunifuSwitch3.TabIndex = 13;
			this.bunifuSwitch3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuSwitch3.Value = true;
			// 
			// bunifuSwitch2
			// 
			this.bunifuSwitch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuSwitch2.BorderRadius = 0;
			this.bunifuSwitch2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuSwitch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuSwitch2.Location = new System.Drawing.Point(164, 97);
			this.bunifuSwitch2.Name = "bunifuSwitch2";
			this.bunifuSwitch2.Oncolor = System.Drawing.Color.SeaGreen;
			this.bunifuSwitch2.Onoffcolor = System.Drawing.Color.DarkGray;
			this.bunifuSwitch2.Size = new System.Drawing.Size(51, 19);
			this.bunifuSwitch2.TabIndex = 12;
			this.bunifuSwitch2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuSwitch2.Value = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(49, 243);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "rastrear";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tab_home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cartesianChart1);
			this.Controls.Add(this.bunifuCustomLabel7);
			this.Controls.Add(this.bunifuCustomLabel6);
			this.Controls.Add(this.bunifuCustomLabel5);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Controls.Add(this.bunifuSwitch4);
			this.Controls.Add(this.bunifuSwitch3);
			this.Controls.Add(this.bunifuSwitch2);
			this.Name = "tab_home";
			this.Size = new System.Drawing.Size(1018, 363);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private LiveCharts.WinForms.CartesianChart cartesianChart1;
		private ns1.BunifuCustomLabel bunifuCustomLabel7;
		private ns1.BunifuCustomLabel bunifuCustomLabel6;
		private ns1.BunifuCustomLabel bunifuCustomLabel5;
		private ns1.BunifuCustomLabel bunifuCustomLabel2;
		private ns1.BunifuSwitch bunifuSwitch4;
		private ns1.BunifuSwitch bunifuSwitch3;
		private ns1.BunifuSwitch bunifuSwitch2;
		private System.Windows.Forms.Button button1;
	}
}
