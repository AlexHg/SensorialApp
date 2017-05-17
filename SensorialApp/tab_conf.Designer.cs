namespace sensorial
{
	partial class tab_conf
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
			this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
			this.SuspendLayout();
			// 
			// bunifuCustomLabel3
			// 
			this.bunifuCustomLabel3.AutoSize = true;
			this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
			this.bunifuCustomLabel3.Location = new System.Drawing.Point(421, 163);
			this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
			this.bunifuCustomLabel3.Size = new System.Drawing.Size(183, 37);
			this.bunifuCustomLabel3.TabIndex = 6;
			this.bunifuCustomLabel3.Text = "Tab_CONF";
			this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
			// 
			// tab_conf
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
			this.Controls.Add(this.bunifuCustomLabel3);
			this.Name = "tab_conf";
			this.Size = new System.Drawing.Size(1018, 363);
			this.Load += new System.EventHandler(this.tab_conf_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ns1.BunifuCustomLabel bunifuCustomLabel3;
	}
}
