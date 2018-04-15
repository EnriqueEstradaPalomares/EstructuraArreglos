using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_con_Arreglos
{
    class Productos
    {
        private int ban = 0;
        private struct producto{
            public string codigo;
            public string nombre;
            public string descripcion;
            public string cantidad;
            public string costo;
        }
        producto[] prod = new producto[15];


        public void llenar(string codigo, string nombre,
            string descripcion, string cantidad, string costo)
        {
            prod[ban].codigo = codigo;
            prod[ban].nombre = nombre;
            prod[ban].descripcion = descripcion;
            prod[ban].cantidad = cantidad;
            prod[ban].costo = costo;
            ban++;
        }

        public string buscar(string codigo)
        {
            bool b = true;
            string data = "";
            for(int i = 0; i < 15; i++)
            {
                b = prod[0].codigo.Contains(codigo);
                if (b)
                {
                   data += "Codigo:" + prod[i].codigo + "| Nombre: " + prod[i].nombre
                        + "| Descripcion: " + prod[i].descripcion +"| Cantidad: " + 
                        prod[i].cantidad + "| Precio: $" + prod[i].costo + "\r\n";
                }
            }
            return data;
        }


        public void insertar(string codigo, string nombre,
            string descripcion, string cantidad, string costo, int pos)
        {
            for (int i = 14; i > pos; i--)
            {
                prod[i] = prod[i - 1];
            }
            prod[pos].codigo = codigo; prod[pos].nombre = nombre; prod[pos].descripcion = descripcion;
            prod[pos].cantidad = cantidad; prod[pos].costo = costo;
        }

        public string Listar()
        {
            string data = "";
            for(int i = 0; i < 15; i++)
            {
                data += i+1 + ".- Codigo:" + prod[i].codigo + "| Nombre: " + prod[i].nombre + "| Descripcion: " + prod[i].descripcion +
                "| Cantidad: " + prod[i].cantidad + "| Precio: $" + prod[i].costo + "\r\n";
            }
            return data;
        }
    }
}
