﻿using Datos.Controllers;
using Datos.Models;
using Presentacion.Views.VistasGerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Views.VistasVendedor
{
    public partial class ProgramaVendedor : Form
    {
        private Form formularioActivo;
        public ProgramaVendedor()
        {
            InitializeComponent();
            customizeDesing();
            this.formularioActivo = null;
        }

        // BOTONES PARA LIBROS
        private void btnLibros_Click(object sender, EventArgs e)
        {
            openChildForm(new VistaLibrosVendedor());
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
            VistaLibrosVendedor vistaLibrosVendedor = new VistaLibrosVendedor();
            vistaLibrosVendedor.LimpiarTabla();
            vistaLibrosVendedor.CargarTabla(libros);
            openChildForm(vistaLibrosVendedor);

        }
        private void btnLibros2_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnLibros2.Text
            };
            List<Libro> libros = new LibrosController().ObtenerLibrosPorGenero(genero);
            VistaLibrosVendedor vistaLibrosVendedor = new VistaLibrosVendedor();
            vistaLibrosVendedor.LimpiarTabla();
            vistaLibrosVendedor.CargarTabla(libros);
            openChildForm(vistaLibrosVendedor);
        }
        private void btnLibros3_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnLibros3.Text
            };
            List<Libro> libros = new LibrosController().ObtenerLibrosPorGenero(genero);
            VistaLibrosVendedor vistaLibrosVendedor = new VistaLibrosVendedor();
            vistaLibrosVendedor.LimpiarTabla();
            vistaLibrosVendedor.CargarTabla(libros);
            openChildForm(vistaLibrosVendedor);
        }
        private void btnLibros4_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnLibros4.Text
            };
            List<Libro> libros = new LibrosController().ObtenerLibrosPorGenero(genero);
            VistaLibrosVendedor vistaLibrosVendedor = new VistaLibrosVendedor();
            vistaLibrosVendedor.LimpiarTabla();
            vistaLibrosVendedor.CargarTabla(libros);
            openChildForm(vistaLibrosVendedor);

        }

        // BOTONES PARA VENTAS Y VENDEDORES
        private void btnVentas_Click(object sender, EventArgs e)
        {
            openChildForm(new VistaVentasVendedor());
            if (!panelVentas.Visible)
            {
                MostrarSubCategorias();
                showSubMenu(panelVentas);

            }
        }

        // FUNCIONES VARIAS PARA HACER DINAMICO EL MENU
        private void customizeDesing()
        {
            panelLibros.Visible = false;
            panelVentas.Visible = false;

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVentas1_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnVentas1.Text
            };
            Genero aux = new GeneroController().ObtenerGenero(btnVentas1.Text);
            List<Venta> ventas = new VentaController().ObtenerVentasGenero(aux.idGenero);
            VistaVentasVendedor vistaVentasVendedor = new VistaVentasVendedor();
            vistaVentasVendedor.CargarTabla(ventas);

            openChildForm(vistaVentasVendedor);
        }

        private void btnVentas2_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnVentas2.Text
            };
            Genero aux = new GeneroController().ObtenerGenero(btnVentas2.Text);
            List<Venta> ventas = new VentaController().ObtenerVentasGenero(aux.idGenero);
            VistaVentasVendedor vistaVentasVendedor = new VistaVentasVendedor();
            vistaVentasVendedor.CargarTabla(ventas);
  
            openChildForm(vistaVentasVendedor);
        }
        private void btnVentas3_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnVentas3.Text
            };
            Genero aux = new GeneroController().ObtenerGenero(btnVentas3.Text);
            List<Venta> ventas = new VentaController().ObtenerVentasGenero(aux.idGenero);
            VistaVentasVendedor vistaVentasVendedor = new VistaVentasVendedor();
            vistaVentasVendedor.CargarTabla(ventas);

            openChildForm(vistaVentasVendedor);
        }

        private void btnVentas4_Click(object sender, EventArgs e)
        {
            List<string> genero = new List<string>
            {
                btnVentas4.Text
            };
            Genero aux = new GeneroController().ObtenerGenero(btnVentas4.Text);
            List<Venta> ventas = new VentaController().ObtenerVentasGenero(aux.idGenero);
            VistaVentasVendedor vistaVentasVendedor = new VistaVentasVendedor();
            vistaVentasVendedor.CargarTabla(ventas);

            openChildForm(vistaVentasVendedor);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            VistaCuentaVendedor vistaCuentaVendedor= new VistaCuentaVendedor();
            openChildForm(vistaCuentaVendedor);
        }
    }
}
