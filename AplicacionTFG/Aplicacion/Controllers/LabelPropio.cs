using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Controllers
{
    public partial class LabelPropio : Label
    {
        public LabelPropio()
        {
            InitializeComponent();
            Font = new Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Size = new Size(45, 20);
            AutoSize = true;
            Name = "labelPropio";
            Text = "labelPropio";
        }
    }
}
