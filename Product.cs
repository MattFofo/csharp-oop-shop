using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
        private int Codice { get; }
        public string nome;
        public string descrizione;
        public double prezzo;
        public double iva;

        public Product(string name, double price, string description, int iva)
        {
            this.nome = name;
            this.prezzo = price;
            this.descrizione = description;
            this.iva = iva;
            Random rand = new Random();
            this.Codice = rand.Next(1, 99);
        }

        public double GetBasicPrice()
        {
            return this.prezzo;
        }

        public double GetPriceAfterIva()
        {
            double ivaPriced = Math.Round((this.prezzo + (this.prezzo / 100 * this.iva)), 2);

            return ivaPriced;
        }

        public string GetFullName()
        {
            string fullName = this.nome + " - " + this.Codice;

            return fullName;
        }

        public string FormatProductCode()
        {
            string baseCode = this.Codice.ToString();
            string formattedCode = baseCode;

            while (formattedCode.Length < 8)
            {
                formattedCode = "0" + formattedCode;
            }

            return formattedCode;
        }
    }
}

