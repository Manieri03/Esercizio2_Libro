using System;
using System.Collections.Generic;

namespace LibreriaLibro
{
    public class Libro
    {
        public List<Pagina> Pagine { get; private set; } = new List<Pagina>();
        List<Sezione> sezioni = new List<Sezione>();

        public Libro() { }

        public string ToString1()
        {
            string testo = "Stampo il libro...";
            foreach (Pagina p in Pagine)
                testo += p.ToString();
            
            return testo;
        }

        public Sezione AddSezione(Sezione s)
        {
            sezioni.Add(s);
            return s;
        }

        public Pagina AddPagina(string testo)
        {
            Pagina p = new Pagina(testo);
            Pagine.Add(p);
            return p;
        }
    }
}
