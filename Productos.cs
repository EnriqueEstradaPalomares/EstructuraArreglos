using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_con_Arreglos
{
    class Productos
    {
        private string[] producto = new string[15];
        private int ban = 0;

        public void llenar(string codigo, string nombre,
            string descripcion, string cantidad, string costo)
        {
            producto[ban] = "Codigo: " + codigo + "| Nombre: " + nombre + "| Descripción" + descripcion 
                + "| Cantidad: " + cantidad + "| Costo: " + costo;
            ban++;
        }

        public string buscar(string pos)
        {
            string data = "";
            for(int i = 0; i < 14; i++)
            {
                if (string.IsNullOrEmpty(producto[i]))
                {
                    data += "No Existe";
                }
                else
                {
                    bool asa = producto[i].Contains(pos);
                    if (asa)
                    {
                        data += producto[i];
                    }
                }
            }
            return data;
        }


        public void insertar(string codigo, string nombre,
            string descripcion, string cantidad, string costo, int pos)
        {
            for(int i = 14; i > pos; i--)
            {
                producto[i] = producto[i - 1];
            }
            producto[pos] = "Codigo: " + codigo + "| Nombre: " + nombre + "| Descripción" + descripcion
                + "| Cantidad: " + cantidad + "| Costo: " + costo;
        }

        public string listar()
        {
            string data = "";
            for(int i = 0; i < 14; i++)
            {
                //if (string.IsNullOrEmpty(vec[i]))
                //{
                //    data = "NULL";
                //}
                //else
                    data += i+1 + "- " + producto[i] + "\r\n";
            }
            return data;
        }
    }
}
