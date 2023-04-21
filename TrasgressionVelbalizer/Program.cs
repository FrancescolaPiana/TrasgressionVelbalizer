using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrasgressionVelbalizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        class Verbale
        {
            public int Id { get; set; }
            public DateTime DataViolazione { get; set; }
            public string Cognome { get; set; }
            public ListaIndirizzi Indirizzi { get; set; }
            public ListaMetodiPagamento MetodiPagamento { get; set; }
            public ListaOrdini Ordini { get; set; }

            public Utente(int id, string n, string c, ListaIndirizzi I, ListaMetodiPagamento p, ListaOrdini o)
            {
                Id = id;
                Nome = n;
                Cognome = c;
                Indirizzi = I;
                MetodiPagamento = p;
                Ordini = o;
            }
        }
}
