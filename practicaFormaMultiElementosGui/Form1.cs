using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaFormaMultiElementosGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            Revisar revisar = new Revisar();

            string capitalMexico = "";
            if (df.Checked)
                capitalMexico = "df";
            else if (gdl.Checked)
                capitalMexico = "gdl";
            else if (mty.Checked)
                capitalMexico = "mty";

            string paisesEuropa = "incorrecto";
            if (portugal.Checked || chile.Checked || reinoUnido.Checked || macedonia.Checked || australia.Checked)
            { 
                if (portugal.Checked && reinoUnido.Checked && macedonia.Checked)
                    paisesEuropa = "correcto";
            }
            else
            {
                paisesEuropa = "sinValores";
            }
            

            decimal estadosMexico = estados.Value;
            string segundaGuerra = calendario.SelectionRange.Start.ToShortDateString();
            string notas = revisar.leerInfo(nombre.Text, codigo.Text, capitalMexico, paisesEuropa, estadosMexico, segundaGuerra);
            if (notas != "")
                nota.Text = notas;
        }
    }
}
