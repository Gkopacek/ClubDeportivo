using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuPrincipalClub.Entidades;

namespace MenuPrincipalClub.Forms
{
    public partial class frmCarnet : Form
    {
        public frmCarnet(Socio socio)
        {
            InitializeComponent();
            // Asignamos los valores del socio al carnet
            txtDocumento.Text = socio.Documento;
            txtNombre.Text = socio.Nombre;
            txtFecha.Text = socio.Fecha_Inscripcion.ToString("dd/MM/yyyy"); // Formateamos la fecha
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {

        }
    }
}
