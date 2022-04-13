using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace EzivnostC
{
    public partial class PrehledyF : Form
    {
        MonthChoice choice = new MonthChoice();
        SeriesCollection seriesViewsVydaje = new SeriesCollection();
        SeriesCollection seriesViewsPrijmy = new SeriesCollection();

        public int rok { get; set; }
        public int mesic { get; set; }

        User user = new User();
        Prehledy p;
        public PrehledyF( User u)
        {   
            this.user = u;

            
            choice.ShowDialog();
            this.rok = choice.rok;
            this.mesic = choice.mesic;
            InitializeComponent();
            load();



        }


       

        
        public void load()
        {
            p = new Prehledy(this.user);
            nacist_prijmy_a_vydje();
            Nacist_Vydaje_chart();
            Nacist_Prijmy_chart();
            PieChartPrijmy.Series = seriesViewsPrijmy;
            Vydaje_pie_chart.Series = seriesViewsVydaje;    
            

        }


        public void Nacist_Prijmy_chart()
            
        {
            this.seriesViewsPrijmy.Clear();
            
            foreach (string x in TypController.nacistTypyPrijmu())
            {
                decimal temp = p.get_report_by_type_Vydej(x, mesic, rok, true);
                if (temp <= 0)
                {
                    continue;

                }
                else
                {
                    PieChartPrijmy_add(temp, x);
                }




            }
        }

        public void PieChartPrijmy_add(decimal castka, string typ)
        {
            seriesViewsPrijmy.Add(new PieSeries
            {
                Title = typ,
                Values = new ChartValues<decimal> { castka },
                DataLabels = true


            }) ; ;




        }
        public void PieChartVydaje_add(decimal castka, string typ)
        {
            seriesViewsVydaje.Add(new PieSeries
            {
                Title = typ,
                Values = new ChartValues<decimal> { castka },
                DataLabels = true


            }); ;
        }


            public void Nacist_Vydaje_chart()
        {   this.seriesViewsVydaje.Clear() ;
            DateTime dt =  DateTime.Now;
            foreach(string x in TypController.nacistTypyVydaju())
            {

                decimal temp = p.get_report_by_type_Vydej(x, mesic, rok, false);
                if (temp <= 0)
                {
                    continue;

                }
                else
                {
                    PieChartVydaje_add(temp, x);
                }


          

            }



        }


        



        public void nacist_prijmy_a_vydje()
        {
           decimal prijmy= p.monthReportPrijmy(this.rok, this.mesic);
            decimal vydaje = p.monthReportVydaje(this.rok, this.mesic);

            this.Label_prijmy_prehledy.Text = prijmy.ToString() + " Kč";

            this.Label_vydaje_prehledy.Text = vydaje.ToString() + " Kč";

            this.Label_Vynos_prehled.Text = (prijmy - vydaje).ToString() + " Kč";


        }

 

        private void Zmenit_mesic_p_button_Click(object sender, EventArgs e)
        {
            choice.ShowDialog();
            this.rok = choice.rok;
            this.mesic = choice.mesic;
            this.load();
        }
    }
}
