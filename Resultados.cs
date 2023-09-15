using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMO
{
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            Tipo.Text = data.TipoPrograma.ToString();

            kldc.Text = data.KLDC.ToString();

            fae.Text = data.FAE.ToString();

            esf.Text = data.esfuerzo.ToString();

            tiemp.Text = data.tiempo.ToString();

            prod.Text = data.productividad.ToString();

            person.Text = data.personal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio log= new Inicio();
            this.Hide();
            log.Show();
        }
    }
}
