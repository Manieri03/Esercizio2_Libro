using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaLibro
{
    public class Sezione
    {
        List<Sezione> sezioni = new List<Sezione>();
        List<Pagina> pagine = new List<Pagina>();
        public Sezione() { }

        public string ToString2()
        {
            string testo = "Stampo la sezione...";
            foreach (Sezione s in sezioni)
            {
                foreach (Pagina p in s.pagine)
                    testo += p.ToString3();   
            }
            foreach (Pagina p in pagine)
                p.ToString3();
            return testo;
        }
    }
}
