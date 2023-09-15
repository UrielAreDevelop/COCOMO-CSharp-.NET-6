using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COCOMO
{
    public partial class Inicio : Form
    {

        public readonly Dictionary<string, float> lenguajeP = new Dictionary<string, float>();

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            lenguajeP.Add("Ensamblador", 320);
            lenguajeP.Add("C", 150);
            lenguajeP.Add("COBOL", 105);
            lenguajeP.Add("Pascal", 91);
            lenguajeP.Add("Prolog / LISP", 64);
            lenguajeP.Add("C++", 64);
            lenguajeP.Add("Visual Basic", 32);
            lenguajeP.Add("SQL", 12);
        }


        private void buttonGuardarInicio_Click(object sender, EventArgs e)
        {

            if (textBoxPF.Text == "")
            {
                MessageBox.Show("Falta llenar los Puntos de Fusion");
                return;

            }if (comboBoxLenguajes.Text == "")
            {
                MessageBox.Show("Escoge el Lenguaje");
                return; 
            }

            data.PuntosFu = float.Parse(textBoxPF.Text); //Convertir variable a tipo FLOAT 
            var LDC = lenguajeP[comboBoxLenguajes.Text]; //Extraer y guardar en una variable datos seleccionados de ComboBox

            data.KLDC = (data.PuntosFu * LDC) / 1000;

            if(data.KLDC <= 50)
            {
                
                data.TipoPrograma = "ORGÁNICO";
                data.a = 3.2f;
                data.e = 1.05f;
                data.c = 2.5f;
                data.d = 0.38f;

            }else if (data.KLDC > 50 && data.KLDC <= 300)
            {

                data.TipoPrograma = "SEMI-ACOPLADO";
                data.a = 3.0f;
                data.e = 1.12f;
                data.c = 2.5f;
                data.d = 0.35f;


            }else if (data.KLDC > 300)
            {

                data.TipoPrograma = "EMPOTRADO";
                data.a = 2.8f;
                data.e = 1.20f;
                data.c = 2.5f;
                data.d = 0.32f;

            }


            Conductores_de_Coste conductores= new Conductores_de_Coste();
            this.Hide();
            conductores.Show();

        }

    }
}
