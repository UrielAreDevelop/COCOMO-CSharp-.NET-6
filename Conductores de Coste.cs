using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOMO
{
    public partial class Conductores_de_Coste : Form
    {

        public readonly Dictionary<string, float> combo1 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo2 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo3 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo4 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo5 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo6 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo7 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo8 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo9 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo10 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo11 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo12 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo13 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo14 = new Dictionary<string, float>();
        public readonly Dictionary<string, float> combo15 = new Dictionary<string, float>();

        public Conductores_de_Coste()
        {
            InitializeComponent();
        }

        private void Conductores_de_Coste_Load(object sender, EventArgs e)
        {

            combo1.Add("Muy Bajo", 0.75f);
            combo1.Add("Bajo", 0.88f);
            combo1.Add("Nominal", 1);
            combo1.Add("Alto", 1.15f);
            combo1.Add("Muy Alto", 1.40f);
            combo1.Add("Extr. Alto", 1);


            combo2.Add("Muy Bajo", 1);
            combo2.Add("Bajo", 0.94f);
            combo2.Add("Nominal", 1);
            combo2.Add("Alto", 1.08f);
            combo2.Add("Muy Alto", 1.16f);
            combo2.Add("Extr. Alto", 1);


            combo3.Add("Muy Bajo", 0.70f);
            combo3.Add("Bajo", 0.85f);
            combo3.Add("Nominal", 1);
            combo3.Add("Alto", 1.15f);
            combo3.Add("Muy Alto", 1.30f);
            combo3.Add("Extr. Alto", 1.65f);


            combo4.Add("Muy Bajo", 1);
            combo4.Add("Bajo", 1);
            combo4.Add("Nominal", 1);
            combo4.Add("Alto", 1.11f);
            combo4.Add("Muy Alto", 1.30f);
            combo4.Add("Extr. Alto", 1.66f);


            combo5.Add("Muy Bajo", 1);
            combo5.Add("Bajo", 1);
            combo5.Add("Nominal", 1);
            combo5.Add("Alto", 1.06f);
            combo5.Add("Muy Alto", 1.21f);
            combo5.Add("Extr. Alto", 1.56f);


            combo6.Add("Muy Bajo", 1);
            combo6.Add("Bajo", 0.87f);
            combo6.Add("Nominal", 1);
            combo6.Add("Alto", 1.15f);
            combo6.Add("Muy Alto", 1.30f);
            combo6.Add("Extr. Alto", 1);


            combo7.Add("Muy Bajo", 1);
            combo7.Add("Bajo", 0.87f);
            combo7.Add("Nominal", 1);
            combo7.Add("Alto", 1.07f);
            combo7.Add("Muy Alto", 1.15f);
            combo7.Add("Extr. Alto", 1);


            combo8.Add("Muy Bajo", 1.46f);
            combo8.Add("Bajo", 1.19f);
            combo8.Add("Nominal", 1);
            combo8.Add("Alto", 0.86f);
            combo8.Add("Muy Alto", 0.71f);
            combo8.Add("Extr. Alto", 1);


            combo9.Add("Muy Bajo", 1.29f);
            combo9.Add("Bajo", 1.13f);
            combo9.Add("Nominal", 1);
            combo9.Add("Alto", 0.91f);
            combo9.Add("Muy Alto", 0.82f);
            combo9.Add("Extr. Alto", 1);


            combo10.Add("Muy Bajo", 1.42f);
            combo10.Add("Bajo", 1.17f);
            combo10.Add("Nominal", 1);
            combo10.Add("Alto", 0.86f);
            combo10.Add("Muy Alto", 0.70f);
            combo10.Add("Extr. Alto", 1);


            combo11.Add("Muy Bajo", 1.21f);
            combo11.Add("Bajo", 1.10f);
            combo11.Add("Nominal", 1);
            combo11.Add("Alto", 0.90f);
            combo11.Add("Muy Alto", 1);
            combo11.Add("Extr. Alto", 1);


            combo12.Add("Muy Bajo", 1.14f);
            combo12.Add("Bajo", 1.07f);
            combo12.Add("Nominal", 1);
            combo12.Add("Alto", 0.95f);
            combo12.Add("Muy Alto", 1f);
            combo12.Add("Extr. Alto", 1);


            combo13.Add("Muy Bajo", 1.24f);
            combo13.Add("Bajo", 1.10f);
            combo13.Add("Nominal", 1);
            combo13.Add("Alto", 0.91f);
            combo13.Add("Muy Alto", 0.82f);
            combo13.Add("Extr. Alto", 1);


            combo14.Add("Muy Bajo", 1.24f);
            combo14.Add("Bajo", 1.10f);
            combo14.Add("Nominal", 1);
            combo14.Add("Alto", 0.91f);
            combo14.Add("Muy Alto", 0.83f);
            combo14.Add("Extr. Alto", 1);


            combo15.Add("Muy Bajo", 1.23f);
            combo15.Add("Bajo", 1.08f);
            combo15.Add("Nominal", 1);
            combo15.Add("Alto", 1.04f);
            combo15.Add("Muy Alto", 1.10f);
            combo15.Add("Extr. Alto", 1);

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" ||
                comboBox5.Text == "" || comboBox6.Text == "" || comboBox7.Text == "" || comboBox8.Text == "" ||
                comboBox9.Text == "" || comboBox10.Text == "" || comboBox11.Text == "" || comboBox12.Text == "" ||
                comboBox13.Text == "" || comboBox14.Text == ""  || comboBox15.Text == "")
            {
                 MessageBox.Show("Faltan Parametros por llenar");
                return;
            }

            var valor1 = combo1[comboBox1.Text];
            var valor2 = combo2[comboBox2.Text];
            var valor3 = combo3[comboBox3.Text];
            var valor4 = combo4[comboBox4.Text];
            var valor5 = combo5[comboBox5.Text];
            var valor6 = combo6[comboBox6.Text];
            var valor7 = combo7[comboBox7.Text];
            var valor8 = combo8[comboBox8.Text];
            var valor9 = combo9[comboBox9.Text];
            var valor10 = combo10[comboBox10.Text];
            var valor11 = combo11[comboBox11.Text];
            var valor12 = combo12[comboBox12.Text];
            var valor13 = combo13[comboBox13.Text];
            var valor14 = combo14[comboBox14.Text];
            var valor15 = combo15[comboBox15.Text];

            //OBTENER FAE
            data.FAE = valor1 * valor2 * valor3 * valor4 * valor5 * valor6 * valor7 * valor8 * valor9 * valor10 * valor11 * valor12 * valor13 * valor14 * valor15;

            //OBTENER ESPUERZO
            data.esfuerzo = data.a * (Math.Pow(data.KLDC, data.e)) * data.FAE;

            //OBTENER TIEMPO
            data.tiempo = data.c * Math.Pow(data.esfuerzo, data.d);

            //OBTENER PRODUCTIVIDAD
            data.productividad = (data.KLDC * 1000) / data.esfuerzo;

            //OBTENER PERSONAL
            data.personal = data.esfuerzo / data.tiempo;


            Resultados res = new Resultados();
            this.Hide();
            res.Show();

        }
    }
}
