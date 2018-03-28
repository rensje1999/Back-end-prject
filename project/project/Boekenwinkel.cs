using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project
{
    public class Boekenwinkel : Boek
    {
        public String ContactGegevens;
        public string OpneningsTijden;
        public int Voorraad;
        public int Verzameling;

        public Bestellingen Bestellingen
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public tijdschrift tijdschrift
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void BoekKopen()
        {
            throw new System.NotImplementedException();
        }

        private void TijdschriftVerkopen()
        {
            throw new System.NotImplementedException();
        }

        private void TonenVoorradigeBoeken()
        {
            throw new System.NotImplementedException();
        }

        private void TonenVoorradigeTijdschriften()
        {
            throw new System.NotImplementedException();
        }

        private void NieuwBoekAanAssortiment()
        {
            throw new System.NotImplementedException();
        }

        private void BoekVerwijderenAssortiment()
        {
            throw new System.NotImplementedException();
        }

        private void NieuwTijdschriftAanAssortiment()
        {
            throw new System.NotImplementedException();
        }

        private void TijdschriftVerwijderenAssortiment()
        {
            throw new System.NotImplementedException();
        }

        private void BestellingGenereren()
        {
            throw new System.NotImplementedException();
        }

        private void BestellingAfgehandeld()
        {
            throw new System.NotImplementedException();
        }

        private void NietVerwerkteBestellingen()
        {
            throw new System.NotImplementedException();
        }

        private void ZoekBestellingOpDatum()
        {
            throw new System.NotImplementedException();
        }

        private void MinMax()
        {
            throw new System.NotImplementedException();
        }

        private void AanpassenMinMax()
        {
            throw new System.NotImplementedException();
        }
    }
}