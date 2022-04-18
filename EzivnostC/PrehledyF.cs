using System;
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
        Roční_přehled rp;

        public int rok { get; set; }
        public int mesic { get; set; }

        User user = new User();
        Prehledy p;
        public PrehledyF( User u)
        {
            
           
            this.user = u;
            rp = new Roční_přehled(u);
            
            
            DateTime now = DateTime.Now;
            rok = now.Year;
            mesic = now.Month;
          
             
            InitializeComponent();
            load();
            this.C_Podle_Typu.Series.Clear();



        }


       

        
        public void load()
        {
           
       

            p = new Prehledy(this.user);
            nacist_prijmy_a_vydje();
            Nacist_Vydaje_chart();
            Nacist_Prijmy_chart();
            PieChartPrijmy.Series = seriesViewsPrijmy;
            Vydaje_pie_chart.Series = seriesViewsVydaje;
            this.C_Podle_Typu.Series = rp.getChart(true);
            this.C_prehled_vynosů.Series = rp.prehled_vynosu();
            this.C_Podle_Typu.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title= "Měsíc",
                Labels = new[] {"Leden","Únor","Březen","Duben","Květen","Červen","Červenec","Srpen", "Záři","Říjen","Listopad","Prosinec"}


            });
            this.C_prehled_vynosů.AxisX.Add(new LiveCharts.Wpf.Axis {


                Title = "Měsíc",
                Labels = new[] { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Záři", "Říjen", "Listopad", "Prosinec" }

            });
            this.C_Podle_Typu.Visible = false;
             
            



        }


        public void Nacist_Prijmy_chart()
            
        {
            this.seriesViewsPrijmy.Clear();
            
            foreach (string x in TypController.nacistTypyPrijmu(this.user))
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
           
            foreach(string x in TypController.nacistTypyVydaju(this.user))
            {

                decimal temp = p.get_report_by_type_Vydej(x, this.mesic, this.rok, false);
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

        private void radioButtonPrijem_CheckedChanged(object sender, EventArgs e)
        {   
            
            this.comboBoxTyp.Text = "";
            this.comboBoxTyp.Items.Clear();
            var list = TypController.nacistTypyPrijmu(this.user);
            foreach (var item in list)
            {
                this.comboBoxTyp.Items.Add(item.ToString());


            }
        }

        private void radioButtonVydaj_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBoxTyp.Text = "";
            this.comboBoxTyp.Items.Clear();
            var list = TypController.nacistTypyVydaju(this.user);
            foreach (var item in list)
            {
                this.comboBoxTyp.Items.Add(item.ToString());


            }

        }

        private void Nacist_graf_Click(object sender, EventArgs e)
        {
            if (!radioButtonPrijem.Checked && !radioButtonVydaj.Checked)
            {
                MessageBox.Show("Zvolte prosim nějakou možnost");

            }
            else
            {
                C_Podle_Typu.Visible = true;
                if (comboBoxTyp.Text == "")
                {

                    this.C_Podle_Typu.Series = rp.getChart(radioButtonPrijem.Checked);

                }
                else
                {
                    C_Podle_Typu.Visible = true;
                    rp.sc.Clear();
                    rp.setTypeValues(comboBoxTyp.Text, radioButtonPrijem.Checked);
                    this.C_Podle_Typu.Series = rp.sc;


                }


            }
        }
    }
}
