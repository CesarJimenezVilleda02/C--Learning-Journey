using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_Win_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSaludo_Click(object sender, EventArgs e)
        {
            LabSaludo.Visible = !LabSaludo.Visible;
            LabSaludo.Text = "Hola amigo";
            this.Text = "Saludando";
        }

        private void BtnDespedida_Click(object sender, EventArgs e)
        {
            LabSaludo.Visible = true;
            LabSaludo.Text = "Adios amigo";
            // This accede a lo de la forma en si
            this.Text = "Adios";
            this.Close();
        }
    }
}
