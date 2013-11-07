using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaFormaMultiElementosGui
{
    class Revisar
    {

        public string leerInfo(string codigo, string nombre,string capitalMexico, int paisesEuropa, decimal estadosMexico, string fechaSegGuerra)
        {
            string resultado;
            int aciertos = 0;

            if (codigo == "" || nombre == "" || capitalMexico == "" || paisesEuropa == -1 || estadosMexico == 0 || fechaSegGuerra == "") 
            {
                MessageBox.Show("Por favor llene todos los campos.");
                return "";
            }
                
               

            if (capitalMexico == "df")
                aciertos++;
            
            if (paisesEuropa !=0)
                aciertos += paisesEuropa;
            
            if (estadosMexico == 31)
                aciertos++;
            
            if (fechaSegGuerra == "07/05/1945")
                aciertos++;
            

            resultado = "Codigo: " + codigo;
            resultado += "\nNombre: " + nombre;
            resultado += "\nAciertos: " + aciertos; 

            return resultado;
        }
    }
}
