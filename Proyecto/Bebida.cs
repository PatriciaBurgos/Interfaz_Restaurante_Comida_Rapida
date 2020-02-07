using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Proyecto
{
	public partial class Bebida : UserControl
	{


		public Bebida()
		{
			InitializeComponent();
		}

		public void actualizar_cantidad(int num, decimal cant)
		{
			((ItemComida)Comida.comidas_array[num]).Cantidad = cant;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown1.Value;
			actualizar_cantidad(12, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown2.Value;
			actualizar_cantidad(13, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown3_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown3.Value;
			actualizar_cantidad(14, a);
			Carrito.aniadir_comida();
			
		}
	}
}
