using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project
{
    public class tijdschrift
    {
        public string Titel;
        public string Auteur;
        public string Taal;
        public string Afmeting;
        public double Gewicht;
        public int Druk;
        public int ISNN;
        public double Prijs;
        public int BestelAantal;
        public Enum BestelDag;

        private void Afdrukken()
        {
            throw new System.NotImplementedException();
        }

        private void TijdschriftBestellen()
        {
            throw new System.NotImplementedException();
        }
    }
}