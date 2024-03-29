﻿using Datos.Controllers;
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
    public partial class ProgramaGerente : Form
    {

        private Form formularioActivo;
        public ProgramaGerente()
        {
            InitializeComponent();
            customizeDesing();
            this.labelTitulo.Text = "";
            this.formularioActivo = null;
        }

        // BOTONES PARA LIBROS
        private void btnLibros_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "Libros";
            openChildForm(new VistaLibrosGerente());
            if (!panelLibros.Visible)
            {
                MostrarSubCategorias();
                showSubMenu(panelLibros);

            }
        }
        private void btnLibros1_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnLibros1.Text
            };
            List<Libro> libros = new LibrosController().ObtenerLibrosPorGenero(genero);
            VistaLibrosGerente vistaLibrosGerente = new VistaLibrosGerente();
            vistaLibrosGerente.LimpiarTabla();
            vistaLibrosGerente.CargarTabla(libros);
            labelTitulo.Text = "Libros";
            openChildForm(vistaLibrosGerente);

        }
        private void btnLibros2_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnLibros2.Text
            };
            List<Libro> libros = new LibrosController().ObtenerLibrosPorGenero(genero);
            VistaLibrosGerente vistaLibrosGerente = new VistaLibrosGerente();
            vistaLibrosGerente.LimpiarTabla();
            vistaLibrosGerente.CargarTabla(libros);
            labelTitulo.Text = "Libros";
            openChildForm(vistaLibrosGerente);
        }
        private void btnLibros3_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnLibros3.Text
            };
            List<Libro> libros = new LibrosController().ObtenerLibrosPorGenero(genero);
            VistaLibrosGerente vistaLibrosGerente = new VistaLibrosGerente();
            vistaLibrosGerente.LimpiarTabla();
            vistaLibrosGerente.CargarTabla(libros);
            labelTitulo.Text = "Libros";
            openChildForm(vistaLibrosGerente);
        }
        private void btnLibros4_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnLibros4.Text
            };
            List<Libro> libros = new LibrosController().ObtenerLibrosPorGenero(genero);
            VistaLibrosGerente vistaLibrosGerente = new VistaLibrosGerente();
            vistaLibrosGerente.LimpiarTabla();
            vistaLibrosGerente.CargarTabla(libros);
            labelTitulo.Text = "Libros";
            openChildForm(vistaLibrosGerente);

        }

        // BOTONES PARA VENTAS Y VENDEDORES
        private void btnVentas_Click(object sender, EventArgs e)
        {
            openChildForm(new VistaVentasGerente());
            labelTitulo.Text = "Ventas";
            if (!panelVentas.Visible)
            {
                MostrarSubCategorias();
                showSubMenu(panelVentas);
            }
        }
        private void btnVentas1_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnVentas1.Text
            };
            Genero aux = new GeneroController().ObtenerGenero(btnVentas1.Text);
            List<Venta> ventas = new VentaController().ObtenerVentasGenero(aux.idGenero);
            VistaVentasGerente vistaVentasGerente = new VistaVentasGerente();
            vistaVentasGerente.CargarTabla(ventas);
            labelTitulo.Text = "Ventas";
            openChildForm(vistaVentasGerente);

        }

        private void btnVentas2_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnVentas2.Text
            };
            Genero aux = new GeneroController().ObtenerGenero(btnVentas2.Text);
            List<Venta> ventas = new VentaController().ObtenerVentasGenero(aux.idGenero);
            VistaVentasGerente vistaVentasGerente = new VistaVentasGerente();
            vistaVentasGerente.CargarTabla(ventas);
            labelTitulo.Text = "Ventas";
            openChildForm(vistaVentasGerente);
        }

        private void btnVentas3_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnVentas3.Text
            };
            Genero aux = new GeneroController().ObtenerGenero(btnVentas3.Text);
            List<Venta> ventas = new VentaController().ObtenerVentasGenero(aux.idGenero);
            VistaVentasGerente vistaVentasGerente = new VistaVentasGerente();
            vistaVentasGerente.CargarTabla(ventas);
            labelTitulo.Text = "Ventas";
            openChildForm(vistaVentasGerente);
        }

        private void btnVentas4_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnVentas4.Text
            };
            Genero aux = new GeneroController().ObtenerGenero(btnVentas4.Text);
            List<Venta> ventas = new VentaController().ObtenerVentasGenero(aux.idGenero);
            VistaVentasGerente vistaVentasGerente = new VistaVentasGerente();
            vistaVentasGerente.CargarTabla(ventas);
            labelTitulo.Text = "Ventas";
            openChildForm(vistaVentasGerente);
        }
        private void btnVendedores_Click(object sender, EventArgs e)
        {
            labelTitulo.Text = "Vendedores";
            openChildForm(new VistaVendedoresGerente());
            if (!panelVendedores.Visible)
            {
                MostrarSubCategorias();
                showSubMenu(panelVendedores);               
            }
        }
        private void btnGeneros_Click(object sender, EventArgs e)
        {
            this.labelTitulo.Text = "Generos";

            if (!panelGeneros.Visible)
            {
                showSubMenu(panelGeneros);
            }

            VistaGenerosGerente vistaGenerosGerente = new VistaGenerosGerente();
            openChildForm(vistaGenerosGerente);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
             
        // FUNCIONES VARIAS PARA HACER DINAMICO EL MENU
        private void customizeDesing()
        {
            panelLibros.Visible = false;
            panelVentas.Visible = false;
            panelVendedores.Visible = false;
            panelGeneros.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelLibros.Visible == true)
            {
                panelLibros.Visible = false;
            }
            if (panelVentas.Visible == true)
            {
                panelVentas.Visible = false;
            }
            if (panelVendedores.Visible == true)
            {
                panelVendedores.Visible = false;
            }
            if (panelGeneros.Visible == true)
            {
                panelGeneros.Visible = false;
            }

        }

        private void openChildForm(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelFormulario.Controls.Add(formulario);
            panelFormulario.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void MostrarSubCategorias()
        {
            List<Genero> generos = new GeneroController().ObtenerGeneros();

            int cantidadGeneros = generos.Count();
            if (cantidadGeneros >= 4)
            {
                btnLibros1.Text = generos[0].nombre;
                btnLibros2.Text = generos[1].nombre;
                btnLibros3.Text = generos[2].nombre;
                btnLibros4.Text = generos[3].nombre;

                btnVentas1.Text = generos[0].nombre;
                btnVentas2.Text = generos[1].nombre;
                btnVentas3.Text = generos[2].nombre;
                btnVentas4.Text = generos[3].nombre;
            }
            else if (cantidadGeneros == 3)
            {
                btnLibros1.Text = generos[0].nombre;
                btnLibros2.Text = generos[1].nombre;
                btnLibros3.Text = generos[2].nombre;
                btnLibros4.Hide();

                btnVentas1.Text = generos[0].nombre;
                btnVentas2.Text = generos[1].nombre;
                btnVentas3.Text = generos[2].nombre;
                btnVentas4.Hide();
            }
            else if (cantidadGeneros == 2)
            {
                btnLibros1.Text = generos[0].nombre;
                btnLibros2.Text = generos[1].nombre;
                btnLibros3.Hide();
                btnLibros4.Hide();

                btnVentas1.Text = generos[0].nombre;
                btnVentas2.Text = generos[1].nombre;
                btnVentas3.Hide();
                btnVentas4.Hide();
            }
            else if (cantidadGeneros == 1)
            {
                btnLibros1.Text = generos[0].nombre;
                btnLibros2.Hide();
                btnLibros3.Hide();
                btnLibros4.Hide();

                btnVentas1.Text = generos[0].nombre;
                btnVentas2.Hide();
                btnVentas3.Hide();
                btnVentas4.Hide();
            }
            else
            {
                btnLibros1.Hide();
                btnLibros2.Hide();
                btnLibros3.Hide();
                btnLibros4.Hide();

                btnVentas1.Hide();
                btnVentas2.Hide();
                btnVentas3.Hide();
                btnVentas4.Hide();

            }
        }

    }
}
