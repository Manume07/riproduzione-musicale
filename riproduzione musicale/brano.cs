using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riproduzione_musicale
{
    internal class brano
    {
        private string _titolo;
        private string _autore;
        private float _durata;

        public brano(string titolo, string autore, float durata)
        {

            _titolo = titolo;
            _autore = autore;
            _durata = durata;

        }

        public string getTitolo()
        {
            return _titolo;
        }

        public string getautore()
        {
            return _autore;
        }

        public float getDurata()
        {
            return _durata;
        }

        public void setTitolo(string titolo)
        {
            _titolo = titolo;
        }

        public void setAutore(string autore)
        {
            _autore = autore;
        }

        public void setDurata(float durata)
        {
            _durata = durata;
        }

        public bool shortSong(float sogliaDurata)
        {
            if (_durata < sogliaDurata)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
