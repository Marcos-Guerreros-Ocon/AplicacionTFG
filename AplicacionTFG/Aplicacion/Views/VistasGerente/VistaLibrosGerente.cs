﻿
using Datos.Controllers;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Views.VistasGerente
{
    public partial class VistaLibrosGerente : Form
    {
        public VistaLibrosGerente()
        {
            InitializeComponent();
            CargarTabla(null);
        }

        public void LimpiarTabla()
        {
            tablaLibros.Rows.Clear();
        }
        public void CargarTabla(List<Libro> listaFiltrada)
        {
            List<Libro> libros;
            if (listaFiltrada is null)
            {
                libros = new LibrosController().ObtenerLibros();
            }
            else
            {
                libros = listaFiltrada;
            }

          

            foreach (Libro libro in libros)
            {
                Genero genero = new GeneroController().ObtenerGenero(libro.idGenero);
                tablaLibros.Rows.Add(libro.isbn,libro.titulo,genero.nombre,libro.autor,libro.precio,libro.stock,"Modificar");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VistaLibroNuevo popup = new VistaLibroNuevo();
            popup.ShowDialog();
            LimpiarTabla();
            CargarTabla(null);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Libro>libros = new LibrosController().ObtenerLibrosPorTitulo(txtBuscar.Text);
            LimpiarTabla();
            CargarTabla(libros);
        }
    }
}
