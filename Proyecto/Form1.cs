using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
	public partial class Form1 : Form
	{
		ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

		public Form1()
		{
			InitializeComponent();
			SlidePanel.Height = button6.Height;
			SlidePanel.Top = button6.Top;
			comida1.Visible = false;
			bebida1.Visible = false;
			carrito1.Visible = false;
			pagar1.Visible = false;
			toolTip1.OwnerDraw = true;
			toolTip1.Draw += new DrawToolTipEventHandler(toolTip1_Draw);

		}
		
		public void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
		{
			Font f = new Font("Candara", 9.0f);
			toolTip1.BackColor = System.Drawing.Color.White;
			e.DrawBackground();
			e.DrawBorder();
			e.Graphics.DrawString(e.ToolTipText, f, Brushes.Black, new PointF(6, 2));
		}


		private void button1_Click(object sender, EventArgs e)
		{
			comida1.Visible = true;
			SlidePanel.Height = button1.Height;
			SlidePanel.Top = button1.Top;
			comida1.BringToFront();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			button6.Enabled = false;
			button1.Enabled = true;
			button2.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			comida1.Visible = true;
			SlidePanel.Height = button1.Height;
			SlidePanel.Top = button1.Top;
			comida1.BringToFront();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			SlidePanel.Height = button2.Height;
			SlidePanel.Top = button2.Top;
			bebida1.BringToFront();
			bebida1.Visible = true;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SlidePanel.Height = button4.Height;
			SlidePanel.Top = button4.Top;
			carrito1.BringToFront();
			carrito1.Visible = true;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			SlidePanel.Height = button5.Height;
			SlidePanel.Top = button5.Top;
			pagar1.BringToFront();
			pagar1.Visible = true;
			pagar1.mostrar_precio_total();
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(button7, "Inicia pedido");
		}
	}
}
