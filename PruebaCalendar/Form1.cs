using System;
using System.Globalization;
using System.Windows.Forms;

namespace PruebaCalendar
{
    public partial class Form1 : Form
    {
        //Variables universales
        int mes, año;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDias();
        }

        //CARGAR DÍAS DEL MES
        private void CargarDias()
        {
            //Día de hoy
            DateTime now = DateTime.Now;
            mes = now.Month;
            año = now.Year;

            //Obtener mes y año 
            String mesn = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbfecha.Text = mesn.ToUpper() + " " + año;

            //Primer día del mes 
            DateTime primerdia = new DateTime(año, mes, 1);

            //Los días del mes
            //Actual
            int days = DateTime.DaysInMonth(año, mes);
            //Anterior
            int mesant = mes - 1;
            if (mes == 1)
            {
                mesant = 12;
            }
            int pdays = DateTime.DaysInMonth(año, mesant); 

            //Covertir primer día del mes a entero
            int diadelasemana = Convert.ToInt32(primerdia.DayOfWeek.ToString("d"));

            //Agregar días del mes anterior
            for (int i = 0; i < diadelasemana; i++)
            {
                UserControl1 ucb = new UserControl1();
                ucb.dias((pdays - diadelasemana) + (i + 1));
                containerCal.Controls.Add(ucb);
            }

            //Agregar días del mes (incluye métodos de días festivos o fines de semana)
            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucdia = new UserControlDay();
                DateTime fechacompleta = new DateTime(año, mes, i);
                string dayweek = fechacompleta.DayOfWeek.ToString(); //Días de la semana (parámetro para validar días sabado y domingo)
                string fest = "";
                if (fechacompleta.Day == 1 && fechacompleta.Month == 1 || fechacompleta.Day == 5 && fechacompleta.Month == 2 ||
                    fechacompleta.Day == 18 && fechacompleta.Month == 3 || fechacompleta.Day == 1 && fechacompleta.Month == 5 ||
                    fechacompleta.Day == 16 && fechacompleta.Month == 9 || fechacompleta.Day == 20 && fechacompleta.Month == 11 ||
                    fechacompleta.Day == 25 && fechacompleta.Month == 12)
                {
                    fest = "val"; //Día festivo
                }
                ucdia.dias(i, dayweek,fest);
                containerCal.Controls.Add(ucdia);
            }

            //Agregar días del siguiente mes
            for (int i = 1; i < (42 - (days + diadelasemana - 1)); i++)
            {
                UserControl1 ucb = new UserControl1();
                ucb.dias(i);
                containerCal.Controls.Add(ucb);
            }
        }


        //IR AL MES ANTERIOR
        private void button1_Click(object sender, EventArgs e)
        {

            //Limpiar contenedor
            containerCal.Controls.Clear();

            //Variables
            mes--;
            //Cambiar año y retornar meses
            if (mes < 1)
            {
                mes = 12;
                año--;
            }
            //Obtener mes y año 
            String mesn = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbfecha.Text = mesn.ToUpper() + " " + año;

            //Primer día del mes
            DateTime primerdia = new DateTime(año, mes, 1);

            //Los días del mes
            //Actual
            int days = DateTime.DaysInMonth(año, mes);
            //Anterior
            int mesant = mes - 1;
            if (mes == 1)
            {
                mesant = 12;
            }
            int pdays = DateTime.DaysInMonth(año, mesant); 

            //Covertir primer día del mes a entero
            int diadelasemana = Convert.ToInt32(primerdia.DayOfWeek.ToString("d"));


            //Agregar días del mes anterior
            for (int i = 0; i < diadelasemana; i++)
            {
                UserControl1 ucb = new UserControl1();
                ucb.dias((pdays - diadelasemana) + (i + 1));
                containerCal.Controls.Add(ucb);
            }

            //Agregar días del mes (incluye métodos de días festivos o fines de semana)
            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucdia = new UserControlDay();
                DateTime fechacompleta = new DateTime(año, mes, i);
                string dayweek = fechacompleta.DayOfWeek.ToString(); //Días de la semana (parámetro para validar días sabado y domingo)
                string fest = "";
                if (fechacompleta.Day == 1 && fechacompleta.Month == 1 || fechacompleta.Day == 5 && fechacompleta.Month == 2 ||
                    fechacompleta.Day == 18 && fechacompleta.Month == 3 || fechacompleta.Day == 1 && fechacompleta.Month == 5 ||
                    fechacompleta.Day == 16 && fechacompleta.Month == 9 || fechacompleta.Day == 20 && fechacompleta.Month == 11 ||
                    fechacompleta.Day == 25 && fechacompleta.Month == 12)
                {
                    fest = "val";//Día festivo
                }
                ucdia.dias(i, dayweek, fest); 
                containerCal.Controls.Add(ucdia);
            }

            //Agregar días del siguiente mes
            for (int i = 1; i < (42 - (days + diadelasemana - 1)); i++)
            {
                UserControl1 ucb = new UserControl1();
                ucb.dias(i);
                containerCal.Controls.Add(ucb);
            }

        }

        //IR AL MES SIGUIENTE
        private void Button2_Click_1(object sender, EventArgs e)
        {

            //Limpiar contenedor
            containerCal.Controls.Clear();

            //Variables
            mes++;

            //Cambiar año y retornar meses
            if (mes > 12) {
                mes = 1;
                año++;
            }
            //Obtener mes y año 
            String mesn = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbfecha.Text = mesn.ToUpper() + " " + año;

            //Primer día del mes
            DateTime primerdia = new DateTime(año, mes, 1);

            //Los días del mes
            //Actual
            int days = DateTime.DaysInMonth(año, mes); 
            
            //Anterior
            int mesant = mes - 1;
            if (mes == 1)
            {
                mesant = 12;
            }
            int pdays = DateTime.DaysInMonth(año, mesant); 

            //Covertir primer día del mes a entero
            int diadelasemana = Convert.ToInt32(primerdia.DayOfWeek.ToString("d"));


            //Agregar días del mes anterior
            int ds = 0;
            for (int i = 0; i < diadelasemana; i++)
            {
                UserControl1 ucb = new UserControl1(); 
                ucb.dias((pdays - diadelasemana) + (i + 1));
                containerCal.Controls.Add(ucb);
            }

            //Agregar días del mes (incluye métodos de días festivos o fines de semana)
            for (int i = 1; i <= days; i++)
            {
                UserControlDay ucdia = new UserControlDay();
                DateTime fechacompleta = new DateTime(año, mes, i);
                string dayweek = fechacompleta.DayOfWeek.ToString(); //Días de la semana (parámetro para validar días sabado y domingo)
                string fest = "";
                if (fechacompleta.Day == 1 && fechacompleta.Month == 1|| fechacompleta.Day == 5 && fechacompleta.Month == 2||
                    fechacompleta.Day == 18 && fechacompleta.Month == 3 || fechacompleta.Day == 1 && fechacompleta.Month == 5 ||
                    fechacompleta.Day == 16 && fechacompleta.Month == 9 || fechacompleta.Day == 20 && fechacompleta.Month == 11 ||
                    fechacompleta.Day == 25 && fechacompleta.Month == 12)
                {
                    fest = "val";//Día festivos
                }
                ucdia.dias(i, dayweek, fest);
                containerCal.Controls.Add(ucdia);
            }

            //Agregar días del siguiente mes
            for (int i = 1; i < (42 - (days+diadelasemana-1)); i++)
            {
                UserControl1 ucb = new UserControl1();
                ucb.dias(i);
                containerCal.Controls.Add(ucb);
            }
        }
    }
}
