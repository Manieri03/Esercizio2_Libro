using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaLibro
{
    public class Pagina
    {
        private string testo = "";
        public Pagina(string t)
        {
            testo=t;
        }

        public string ToString3()
        {
            return testo;
        }

    }
}
