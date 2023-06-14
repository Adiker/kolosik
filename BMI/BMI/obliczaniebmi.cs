using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    public class obliczaniebmi
    {
        private double wiek;
        private double waga;
        private double wzrost;
        private string plec;
        private double bmioblicz;
        private double ppm;
        private double cpm;
        private string aktywnosc;


        public double Wiek
        {
            get { return wiek; }
            set { wiek = value; }
        }
        public double Waga
        {
            get { return waga; }
            set { waga = value; }
        }
        public double Wzrost
        {
            get { return wzrost; }
            set { wzrost = value; }
        }
        public string Plec
        {
            get { return plec; }
            set { plec = value; }
        }
        public double Bmioblicz
        {
            get { return bmioblicz; }
            set { bmioblicz = value; }
        }
        public double Ppm
        {
            get { return ppm; }
            set { ppm = value; }
        }
        public double Cpm
        {
            get { return cpm; }
            set { cpm = value; }
        }
        public string Aktywnosc
        {
            get { return aktywnosc; }
            set { aktywnosc = value; }
        }

        public obliczaniebmi()
        {
            wiek = 0;
            waga = 0;
            wzrost = 0;
            plec = "";
            bmioblicz = 0;
            ppm = 0;
            cpm = 0;
            aktywnosc = "";
        }
        
        public obliczaniebmi(double wiek, double waga, double wzrost, double bmioblicz, string plec, double ppm, double cpm, string aktywnosc)
        {
            this.wiek = wiek;
            this.waga = waga;
            this.wzrost = wzrost;
            this.plec = plec;
            this.ppm = ppm;
            this.cpm = cpm;
            this.bmioblicz = bmioblicz;
            this.aktywnosc = aktywnosc;
        }

        public string wyswietlBMI()
        {
            //return("Twoje BMI wynosi: "+waga/Math.Pow((wzrost/100),2));
            return ("Wiek: " + wiek + ", Waga: " + waga + ", Wzrost: " + wzrost + ", Plec: " + plec + ", PPM: " + ppm + ", CPM: " + cpm + ", BMI: " + bmioblicz + ", Aktywność: " + aktywnosc); ;
        }

        
    }
}
