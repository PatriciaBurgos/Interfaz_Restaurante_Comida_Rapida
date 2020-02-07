using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
	public partial class Pagar : UserControl
	{
		decimal multip,res,precio,canti;
		int cont;
		ToolTip toolTip2 = new System.Windows.Forms.ToolTip();


		public Pagar()
		{
			InitializeComponent();
			toolTip2.OwnerDraw = true;
			toolTip2.Draw += new DrawToolTipEventHandler(toolTip2_Draw);
		}

		public void toolTip2_Draw(object sender, DrawToolTipEventArgs e)
		{
			Font f = new Font("Candara", 9.0f);
			toolTip2.BackColor = System.Drawing.Color.White;
			e.DrawBackground();
			e.DrawBorder();
			e.Graphics.DrawString(e.ToolTipText, f, Brushes.Black, new PointF(6, 2));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			descuento();
		}

		private void descuento()
		{
			if (textBox1.Text != "patri")
			{
				label7.Text = "CUPÓN ERRONEO";
			}
			else
			{
				label7.Text = "CUPÓN VÁLIDO";
				res = res / 2;
				label5.Text = res + "€";
				label6.Text = "El total a pagar es " + res + "€. Ve a la caja para realizar el pago y poner en orden tu pedido. Gracias.";
				cont = 1;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (res != 0)
			{
				Application.Restart();
			}
			else
			{
				label8.Visible = true;
				label8.Text = "Seleccione un producto para terminar";
			}
			
		}

		private void Pagar_Load(object sender, EventArgs e)
		{
			toolTip2.SetToolTip(button3, "Finaliza pedido");
		}

		public void mostrar_precio_total()
		{
			
			res = 0;
			for (int i = 0; i < Comida.comidas_array.Count; i++)
			{
				if (((ItemComida)Comida.comidas_array[i]).Cantidad != 0)
				{
					precio = ((ItemComida)Comida.comidas_array[i]).Precio_uno;
					canti = ((ItemComida)Comida.comidas_array[i]).Cantidad;

					multip = precio * canti;
					res += multip;
				}
			}

			label5.Text = res + "€";
			label6.Text = "El total a pagar es " + res + "€. Ve a la caja para realizar el pago y poner en orden tu pedido. Gracias.";
			label6.Visible = true;
			label8.Visible = false;
			if (res == 0)
			{
				label6.Visible = false;
			}
			if (cont == 1)
			{
				descuento();
			}
			precio = 0;
			canti = 0;
			
		}

		private void button2_Click(object sender, EventArgs e)
		{			
		}
	}
}
