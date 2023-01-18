using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Controllers
{
    public partial class BotonPropio : BotonRedondeadoPropio
    {
        public BotonPropio()
        {
            InitializeComponent();
        }

        public BotonPropio(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            BorderColor = System.Drawing.Color.DarkGray;
            ForeColor = System.Drawing.Color.Coral;
            Font = new System.Drawing.Font("Segoe UI", 9F);
            ForeColor = System.Drawing.Color.White;
            Size = new System.Drawing.Size(180, 45);
            Name = "botonPropio";
            Text = "botonPropio";


        }
    }
}
