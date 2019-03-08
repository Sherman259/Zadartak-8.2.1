using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_8._1._3
{
    class Zaposlenik
    {
        #region Svojstva

        string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        string oib;
        public string OIB
        {

            get { return oib; }
            set { prezime = value; }
        }

        double brojBodova;
        public double BrojBodova
        {
            get { return brojBodova; }
            set
            {
                if (value > 0)
                {
                    brojBodova = value;
                }

                else
                {
                    Exception ex = new Exception("Mozete uneti samo pozitivan broj");
                    throw ex;
                }
            }
        }

        double vrijednostBoda;
        public double VrijednostBoda
        {
            get { return vrijednostBoda; }
            set

            {
                if (value > 0)
                {
                    vrijednostBoda = value;
                }
                else
                {
                    Exception ex = new Exception("Mozete uneti samo pozitivan broj");
                    throw ex;
                }
            }
        }

        // ReadOnly svojstvo
        public double porez
        {
            get
            {
                double neto = this.NetoIzracunPlace();
                if (neto < 3000)
                {
                    return neto * 0.06;
                }

                else if (neto < 6000)
                {
                    return neto * 0.12;
                }
                else
                {
                    return neto * 0.2;
                }
            }
        }



        #endregion

        #region  metode
        public double NetoIzracunPlace()
        {
            return this.BrojBodova * this.VrijednostBoda;
        }
        public double BrutoIzracunPlace()
        {
            return this.NetoIzracunPlace() + this.porez;
        }

        #endregion

        #region Konstruktori

        public Zaposlenik() { }

        public Zaposlenik(string ime, string prezime)
        {

            this.Ime = ime;
            this.Prezime = prezime;
        }

        public Zaposlenik(string ime, string prezime, string oib)
        {

            this.Ime = ime;
            this.Prezime = prezime;
            this.oib = OIB;
        }

        #endregion
    }








}





























