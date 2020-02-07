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
{ //Necesito métodos staticos para llamar a estas clases en la ventana de comida o bebida y añadirlos al list view
	public partial class Carrito : UserControl
	{

		////public ArrayList comida_en_carrito;
		//public static ListView listview;
		//public static ListViewItem item1;
		//public static ListViewItem item2;
		//public static ListViewItem item3;

		//public Carrito()
		//{
		//	InitializeComponent();
		//	//comida_en_carrito = new ArrayList();
		//	listview = new ListView();
		//	//listbox.Size = new Size (797, 498);
		//	listview = listView1;

		//	item1 = new ListViewItem("NOMBRE", 0);
		//	item2 = new ListViewItem("CANTIDAD", 0);
		//	item3 = new ListViewItem("PRECIO", 0);

		//	//listview.Columns.Add("NOMBRE", -2, HorizontalAlignment.Left);
		//	//listview.Columns.Add("CANTIDAD", -2, HorizontalAlignment.Left);
		//	//listview.Columns.Add("PRECIO", -2, HorizontalAlignment.Left);

		//	listview.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

		//}

		//public static void aniadir_comida()			
		//{ //Voy a ir añadiendo los item que se pulsen en el formulario (No se si es itemcomida o comida)
		//	eliminar_items();

		//	for (int i = 0; i<Comida.comidas_array.Count; i++)
		//	{
		//		if(((ItemComida)Comida.comidas_array[i]).Cantidad != 0)
		//		{
		//			ListViewItem item = new ListViewItem();
		//			item.SubItems.Add(((ItemComida)Comida.comidas_array[i]).Nombre);
		//			item.SubItems.Add(((ItemComida)Comida.comidas_array[i]).Cantidad.ToString());
		//			item.SubItems.Add(((ItemComida)Comida.comidas_array[i]).Precio_uno.ToString());
		//			listview.Items.Add(item);

		//			//      listview.Items(0).SubItems(0).Text(((ItemComida)Comida.comidas_array[i]).Nombre));
		//			//listview.Items[1].SubItems.Add(((ItemComida)Comida.comidas_array[i]).Cantidad.ToString());
		//			//listview.Items[2].SubItems.Add(((ItemComida)Comida.comidas_array[i]).Precio_uno.ToString());
		//		}
		//	}
		//}

		//public static void eliminar_items()
		//{
		//	listview.Items.Clear();
		//	listview.Hide();
		//	listview.Show();
		//}

		//public ArrayList comida_en_carrito;
		public static ListBox listbox;
		static int cont;

		public Carrito()
		{
			InitializeComponent();
			//comida_en_carrito = new ArrayList();
			cont = 0;
			listbox = new ListBox();
			//listbox.Size = new Size (797, 498);
			listbox = listBox1;
		}

		public static void aniadir_comida()
		{ //Voy a ir añadiendo los item que se pulsen en el formulario (No se si es itemcomida o comida)
			eliminar_items();

			for (int i = 0; i < Comida.comidas_array.Count; i++)
			{
				if (((ItemComida)Comida.comidas_array[i]).Cantidad != 0)
				{
					listbox.Items.Add("NOMBRE: " +((ItemComida)Comida.comidas_array[i]).Nombre + "---->" +
						"CANTIDAD: " + ((ItemComida)Comida.comidas_array[i]).Cantidad + "---->" +
						"PRECIO(DE UNO): " + ((ItemComida)Comida.comidas_array[i]).Precio_uno);
				}
			}
		}

		public static void eliminar_items()
		{
			listbox.Items.Clear();
			listbox.Hide();
			listbox.Show();
		}

	}
}
