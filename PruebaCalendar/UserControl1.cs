using System;
using System.Windows.Forms;

namespace PruebaCalendar
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        //Método para ingresar el día
        public void dias(int numero)
        {
            lbdia.Text = numero + "";
        } 
    }
}
