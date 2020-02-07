using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{ //Esta clase es para guardar todas las comidas

	class ItemComida {
		//Lo de mateo es ir cambiando los ids (actualizando)
		int id; //Mis id empiezan en 0
		String nombre;
		decimal cantidad;
		decimal precio_uno; //luego se multiplica por la cantidad

		public int Id { get => id; set => id = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public decimal Cantidad { get => cantidad; set => cantidad = value; }
		public decimal Precio_uno { get => precio_uno; set => precio_uno = value; }

		public void itemComidaNuevo(ItemComida nuevo, int ids, String nom, decimal cant, decimal prec)
		{			
			nuevo.Id = ids;
			nuevo.Nombre = nom;
			nuevo.Cantidad = cant; //Si la cantidad en 0 se elimina del array 
			nuevo.Precio_uno = prec;
		}

	}
}
