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
	public partial class Comida : UserControl
	{

		//Array de comidas que se van añadiendo al otro array de itemcomida. Tiene su id, nombre, cantidad y precio. Se busca por nombre.

		public static ArrayList comidas_array;

		public Comida()
		{
			InitializeComponent();
			comidas_array = new ArrayList();
			agregar_todas_las_comidas();
		}

		public void agregar_todas_las_comidas()
		{
			ItemComida item1 = new ItemComida();
			item1.itemComidaNuevo(item1, 0,"Fondue Burger Extra", 0, 8);
			comidas_array.Add(item1);

			ItemComida item2 = new ItemComida();
			item1.itemComidaNuevo(item2, 1, "The King Bacon", 0, 7);
			comidas_array.Add(item2);

			ItemComida item3 = new ItemComida();
			item1.itemComidaNuevo(item3, 2, "Doble Cheese Burger BBQ", 0, 7);
			comidas_array.Add(item3);

			ItemComida item4 = new ItemComida();
			item1.itemComidaNuevo(item4, 3, "Palitos de Gouda", 0, 3);
			comidas_array.Add(item4);

			ItemComida item5 = new ItemComida();
			item1.itemComidaNuevo(item5, 4, "Patatas Clásicas", 0, 1);
			comidas_array.Add(item5);

			ItemComida item6 = new ItemComida();
			item1.itemComidaNuevo(item6, 5, "Patatas Deluxe", 0, 2);
			comidas_array.Add(item6);

			ItemComida item7 = new ItemComida();
			item1.itemComidaNuevo(item7, 6, "Ensalada Original", 0, 5);
			comidas_array.Add(item7);

			ItemComida item8 = new ItemComida();
			item1.itemComidaNuevo(item8, 7, "Rebel Whooper", 0, 6);
			comidas_array.Add(item8);

			ItemComida item9 = new ItemComida();
			item1.itemComidaNuevo(item9, 8, "Ensalada con Pollo Crujiente y Salsa César", 0, 6);
			comidas_array.Add(item9);

			ItemComida item10 = new ItemComida();
			item1.itemComidaNuevo(item10, 9, "Menu TenderCrisp", 0, 5);
			comidas_array.Add(item10);

			ItemComida item11 = new ItemComida();
			item1.itemComidaNuevo(item11, 10, "Menu Long Chicken", 0, 4);
			comidas_array.Add(item11);

			ItemComida item12 = new ItemComida();
			item1.itemComidaNuevo(item12, 11, "Crispy Chicken", 0, 5);
			comidas_array.Add(item12);

			ItemComida item13 = new ItemComida();
			item13.itemComidaNuevo(item13, 12, "Coca-Cola", 0, 2);
			Comida.comidas_array.Add(item13);

			ItemComida item14 = new ItemComida();
			item14.itemComidaNuevo(item14, 13, "Fanta-Naranja", 0, 2);
			Comida.comidas_array.Add(item14);

			ItemComida item15 = new ItemComida();
			item15.itemComidaNuevo(item15, 14, "Agua", 0, 1);
			Comida.comidas_array.Add(item15);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Glúten, Productos lácteos, Puede contener trazas de soja, Puede contener trazas de huevo, Puede contener trazas de sésamo.");
		}
		
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Glúten, Mostaza, Productos lácteos, Huevo, Puede contener trazas de soja, Puede contener trazas de sésamo");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Glúten, Productos lácteos, Sésamo, Dióxido de azufre/Sulfitos, Puede contener trazas de soja, Puede contener trazas de huevo");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Glúten, Productos lácteos, Puede contener trazas de soja, Puede contener trazas de huevo, Puede contener trazas de apio, Puede contener trazas de pescado.");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Puede contener trazas de glúten");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Glúten, Mostaza, Soja, Huevo, Dióxido de azufre/sulfitos");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("-");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Glúten, Soja, Huevo, Apio, Sésamo, Puede contener trazas de productos lácteos");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Glúten, Productos lácteos, Huevo, Apio, Puede contener trazas de mostaza, Puede contener trazas de soja");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Glúten, Huevo, Apio, Dióxido de azufre/sulfitos, Puede contener trazas de altramuces, Puede contener trazas de mostaza, Puede contener trazas de soja, Puede contener trazas de productos lácteos, Puede contener trazas de sésamo");
		}

		private void button11_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Glúten, Huevo, Apio, Sésamo, Dióxido de azufre/sulfitos, Puede contener trazas de altramuces, Puede contener trazas de mostaza, Puede contener trazas de soja, Puede contener trazas de productos lácteos");
		}

		private void button12_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Glúten, Huevo, Apio, Sésamo, Dióxido de azufre/sulfitos, Puede contener trazas de altramuces, Puede contener trazas de mostaza, Puede contener trazas de soja, Puede contener trazas de productos lácteos");
		}

		public void actualizar_cantidad(int num, decimal cant)
		{
			((ItemComida)comidas_array[num]).Cantidad = cant;
		}

		public void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown1.Value;
			actualizar_cantidad(0, a);
			Carrito.aniadir_comida();
					
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown2.Value;
			
			actualizar_cantidad(1, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown3_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown3.Value;
			actualizar_cantidad(2, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown4_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown4.Value;
			actualizar_cantidad(3, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown5_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown5.Value;
			actualizar_cantidad(4, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown6_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown6.Value;
			actualizar_cantidad(5, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown7_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown7.Value;
			actualizar_cantidad(6, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown8_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown8.Value;
			actualizar_cantidad(7, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown9_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown9.Value;
			actualizar_cantidad(8, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown10_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown10.Value;
			actualizar_cantidad(9, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown11_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown11.Value;
			actualizar_cantidad(10, a);
			Carrito.aniadir_comida();
			
		}

		private void numericUpDown12_ValueChanged(object sender, EventArgs e)
		{
			decimal a = numericUpDown12.Value;
			actualizar_cantidad(11, a);
			Carrito.aniadir_comida();
			
		}
	}
}