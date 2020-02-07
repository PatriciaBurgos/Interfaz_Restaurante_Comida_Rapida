namespace Proyecto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.SlidePanel = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.comida1 = new Proyecto.Comida();
			this.pagar1 = new Proyecto.Pagar();
			this.carrito1 = new Proyecto.Carrito();
			this.bebida1 = new Proyecto.Bebida();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.SlidePanel);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 498);
			this.panel1.TabIndex = 0;
			// 
			// SlidePanel
			// 
			this.SlidePanel.BackColor = System.Drawing.Color.Yellow;
			this.SlidePanel.Location = new System.Drawing.Point(0, 109);
			this.SlidePanel.Name = "SlidePanel";
			this.SlidePanel.Size = new System.Drawing.Size(10, 51);
			this.SlidePanel.TabIndex = 1;
			// 
			// button6
			// 
			this.button6.FlatAppearance.BorderSize = 2;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.Yellow;
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.Location = new System.Drawing.Point(0, 108);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(200, 52);
			this.button6.TabIndex = 6;
			this.button6.Text = "Inicio";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Enabled = false;
			this.button5.FlatAppearance.BorderSize = 2;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Yellow;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.Location = new System.Drawing.Point(0, 339);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(200, 52);
			this.button5.TabIndex = 5;
			this.button5.Text = "Pagar";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Enabled = false;
			this.button4.FlatAppearance.BorderSize = 2;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Yellow;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(0, 281);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(200, 52);
			this.button4.TabIndex = 4;
			this.button4.Text = "Carrito";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.FlatAppearance.BorderSize = 2;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Yellow;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(0, 223);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(200, 52);
			this.button2.TabIndex = 2;
			this.button2.Text = "Bebida";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Yellow;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(0, 165);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 52);
			this.button1.TabIndex = 1;
			this.button1.Text = "Comida";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Black;
			this.button7.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
			this.button7.ForeColor = System.Drawing.Color.Yellow;
			this.button7.Location = new System.Drawing.Point(558, 338);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(121, 42);
			this.button7.TabIndex = 8;
			this.button7.Text = "INICIAR";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(525, 84);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(185, 179);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(971, 474);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 24);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			// 
			// comida1
			// 
			this.comida1.BackColor = System.Drawing.Color.White;
			this.comida1.Location = new System.Drawing.Point(198, 0);
			this.comida1.Name = "comida1";
			this.comida1.Size = new System.Drawing.Size(797, 498);
			this.comida1.TabIndex = 10;
			// 
			// pagar1
			// 
			this.pagar1.BackColor = System.Drawing.Color.White;
			this.pagar1.Location = new System.Drawing.Point(198, 0);
			this.pagar1.Name = "pagar1";
			this.pagar1.Size = new System.Drawing.Size(797, 498);
			this.pagar1.TabIndex = 13;
			// 
			// carrito1
			// 
			this.carrito1.BackColor = System.Drawing.Color.White;
			this.carrito1.Location = new System.Drawing.Point(198, 0);
			this.carrito1.Name = "carrito1";
			this.carrito1.Size = new System.Drawing.Size(797, 498);
			this.carrito1.TabIndex = 12;
			// 
			// bebida1
			// 
			this.bebida1.AutoScroll = true;
			this.bebida1.BackColor = System.Drawing.Color.White;
			this.bebida1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.bebida1.Location = new System.Drawing.Point(198, 0);
			this.bebida1.Name = "bebida1";
			this.bebida1.Size = new System.Drawing.Size(797, 498);
			this.bebida1.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(997, 498);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comida1);
			this.Controls.Add(this.pagar1);
			this.Controls.Add(this.carrito1);
			this.Controls.Add(this.bebida1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BurgerKing";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Panel SlidePanel;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private Comida comida1;
		private Bebida bebida1;
		public Carrito carrito1;
		private Pagar pagar1;
	}
}

