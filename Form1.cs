using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo v;
            v = new Vehiculo();
            v.Llantas = "Rodada 16";
            MessageBox.Show(v.ToString());
        }

        private void btnMotocicleta_Click_1(object sender, EventArgs e)
        {
            Motocicleta m;
            m = new Motocicleta();
            m.Llantas = "Rodada 16";
            m.Marca = "Suzuki";
            MessageBox.Show(m.ToString());

        }

        private void btnCuatrimoto_Click(object sender, EventArgs e)
        {
            Cuatrimoto c;
            c = new Cuatrimoto();
            c.Llantas = "Rodada 16";
            c.Marca = "Suzuki";
            c.Color = "Rojo";
            MessageBox.Show(c.ToString());

        }
    }
}
