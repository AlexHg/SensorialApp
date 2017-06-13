namespace sensorial
{
	partial class tab_calc
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
			this.bunifuDropdown1 = new ns1.BunifuDropdown();
			this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
			this.Valor1 = new ns1.BunifuMetroTextbox();
			this.Valor2 = new ns1.BunifuMetroTextbox();
			this.Resultado = new ns1.BunifuMetroTextbox();
			this.SuspendLayout();
			// 
			// bunifuDropdown1
			// 
			this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuDropdown1.BorderRadius = 3;
			this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
			this.bunifuDropdown1.Items = new string[] {
        "Suma",
        "Resta",
        "División",
        "Multiplicación"};
			this.bunifuDropdown1.Location = new System.Drawing.Point(434, 118);
			this.bunifuDropdown1.Name = "bunifuDropdown1";
			this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.bunifuDropdown1.selectedIndex = 0;
			this.bunifuDropdown1.Size = new System.Drawing.Size(150, 42);
			this.bunifuDropdown1.TabIndex = 0;
			this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
			// 
			// bunifuCustomLabel7
			// 
			this.bunifuCustomLabel7.AutoSize = true;
			this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bunifuCustomLabel7.Location = new System.Drawing.Point(27, 45);
			this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
			this.bunifuCustomLabel7.Size = new System.Drawing.Size(245, 31);
			this.bunifuCustomLabel7.TabIndex = 19;
			this.bunifuCustomLabel7.Text = "Calculadora básica";
			this.bunifuCustomLabel7.Click += new System.EventHandler(this.bunifuCustomLabel7_Click);
			// 
			// Valor1
			// 
			this.Valor1.BorderColorFocused = System.Drawing.Color.Blue;
			this.Valor1.BorderColorIdle = System.Drawing.Color.White;
			this.Valor1.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.Valor1.BorderThickness = 3;
			this.Valor1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Valor1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.Valor1.ForeColor = System.Drawing.Color.White;
			this.Valor1.isPassword = false;
			this.Valor1.Location = new System.Drawing.Point(244, 116);
			this.Valor1.Margin = new System.Windows.Forms.Padding(4);
			this.Valor1.Name = "Valor1";
			this.Valor1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.Valor1.Size = new System.Drawing.Size(182, 44);
			this.Valor1.TabIndex = 20;
			this.Valor1.Text = "0";
			this.Valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// Valor2
			// 
			this.Valor2.BorderColorFocused = System.Drawing.Color.Blue;
			this.Valor2.BorderColorIdle = System.Drawing.Color.White;
			this.Valor2.BorderColorMouseHover = System.Drawing.Color.Blue;
			this.Valor2.BorderThickness = 3;
			this.Valor2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Valor2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.Valor2.ForeColor = System.Drawing.Color.White;
			this.Valor2.isPassword = false;
			this.Valor2.Location = new System.Drawing.Point(590, 116);
			this.Valor2.Margin = new System.Windows.Forms.Padding(4);
			this.Valor2.Name = "Valor2";
			this.Valor2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.Valor2.Size = new System.Drawing.Size(182, 44);
			this.Valor2.TabIndex = 21;
			this.Valor2.Text = "0";
			this.Valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// Resultado
			// 
			this.Resultado.BorderColorFocused = System.Drawing.Color.White;
			this.Resultado.BorderColorIdle = System.Drawing.Color.White;
			this.Resultado.BorderColorMouseHover = System.Drawing.Color.White;
			this.Resultado.BorderThickness = 3;
			this.Resultado.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Resultado.Font = new System.Drawing.Font("Century Gothic", 19.75F);
			this.Resultado.ForeColor = System.Drawing.Color.White;
			this.Resultado.isPassword = false;
			this.Resultado.Location = new System.Drawing.Point(244, 182);
			this.Resultado.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
			this.Resultado.Name = "Resultado";
			this.Resultado.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.Resultado.Size = new System.Drawing.Size(528, 105);
			this.Resultado.TabIndex = 22;
			this.Resultado.Text = "Resultado";
			this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// tab_calc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
			this.Controls.Add(this.Resultado);
			this.Controls.Add(this.Valor2);
			this.Controls.Add(this.Valor1);
			this.Controls.Add(this.bunifuCustomLabel7);
			this.Controls.Add(this.bunifuDropdown1);
			this.Name = "tab_calc";
			this.Size = new System.Drawing.Size(1018, 363);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ns1.BunifuDropdown bunifuDropdown1;
		private ns1.BunifuCustomLabel bunifuCustomLabel7;
		private ns1.BunifuMetroTextbox Valor1;
		private ns1.BunifuMetroTextbox Valor2;
		private ns1.BunifuMetroTextbox Resultado;
	}
}
