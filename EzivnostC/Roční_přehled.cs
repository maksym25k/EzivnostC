using System;
using System.Collections.Generic;
using LiveCharts;
using LiveCharts.WinForms;

namespace EzivnostC
{
    public class Roční_přehled
    {
        public User u;
        public int rok;
        int finalMesic;
        
        public SeriesCollection sc = new SeriesCollection();
        DateTime dt = DateTime.Now;
        Prehledy p;

        public Roční_přehled(User u)
        {
            this.u = u;
            p = new Prehledy(u);
            finalMesic = DateTime.Now.Month;

        }


        public SeriesCollection prehled_vynosu()
        {   SeriesCollection local = new SeriesCollection();
            ChartValues<decimal> cv = new ChartValues<decimal>();
            for (int x = 1; x <= finalMesic; x++)
            {
                decimal prijmy = p.monthReportPrijmy(DateTime.Now.Year, x);
                decimal vydaje = p.monthReportVydaje(DateTime.Now.Year, x);
                cv.Add(prijmy-vydaje);

            }
           
                local.Add(new LiveCharts.Wpf.LineSeries
                {
                    Values = cv,
                    Title= "Výnos"


                });
            return local;
        }


        public void setTypeValues(string type, bool prijem)
        {
            ChartValues<decimal> values = new ChartValues<decimal>();
            rok = dt.Year;
            finalMesic = dt.Month;
            for (int x = 1;x<=finalMesic; x++)
            {

                values.Add(p.get_report_by_type_Vydej(type,x,rok,prijem)); 
            }

            sc.Add(new LiveCharts.Wpf.LineSeries
            {
                Values = values,
                Tag = type,
                Title = type
            }
            ) ;
            


  
        }
        public void set_values_of_all(bool prijem)
        {
            sc.Clear();
            if (prijem)
            {

                foreach (string t in TypController.nacistTypyPrijmu(this.u))
                {
                    setTypeValues(t, prijem);


                }
            }
            else
            {
                foreach (string t in TypController.nacistTypyVydaju(this.u))
                {
                    setTypeValues(t, prijem);


                }

            }

        }

       

        public SeriesCollection getChart(bool prijem)
        {
            set_values_of_all(prijem);
            
            return this.sc;


        }
    }
}