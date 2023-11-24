using System;
using System.Windows.Forms;

namespace PruebaCalendar
{
    public partial class UserControlDay : UserControl
    {
        public UserControlDay()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //METODO TEXTO PARA INGRESAR DÍA Y VALIDAR DÍAS FESTÍVOS O FINES DE SEMANA
        public void dias(int numero, string diase, string fest)
        {
            //Añadir fecha
            lbdia.Text = numero + "";

            //Funciones de comparación
            if (fest == "val") //Validar días festívos
            { 
                lbdia.ForeColor = System.Drawing.Color.Black;
                lbdia.BackColor = System.Drawing.Color.Orange;
            }
            else if(diase == "Saturday" || diase == "Sunday") //Validar fines de semana
            {
            lbdia.ForeColor = System.Drawing.Color.Black;
            lbdia.BackColor = System.Drawing.Color.Yellow;
            }
            else //Validar el resto de días
            { 
                lbdia.ForeColor = System.Drawing.Color.White;
                lbdia.BackColor = System.Drawing.Color.Green;
            }
        }




    }
}
