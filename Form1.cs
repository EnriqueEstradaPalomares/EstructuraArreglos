﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_con_Arreglos
{
    public partial class Form1 : Form
    {
        Productos prod = new Productos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarTxt();
            prod.llenar(txtCodigo.Text, txtNombre.Text, txtDesc.Text, 
                txtCantidad.Text, txtCosto.Text);
            txtLista.Text = "Producto Agregado";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtLista.Text = "Resultado de Busqueda \r\n" + prod.buscar(txtCodigo.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            prod.insertar(txtCodigo.Text, txtNombre.Text, txtDesc.Text,
                txtCantidad.Text, txtCosto.Text,Convert.ToInt16(txtPos.Text));
            txtLista.Text = "Producto insertado";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text = "Lista:\r\n" + prod.listar();
        }

        public void limpiarTxt()
        {
            txtCodigo.Text = " ";
            txtNombre.Text = " ";
            txtDesc.Text = " ";
            txtCantidad.Text = " ";
            txtCosto.Text = " ";

        }
    }
}