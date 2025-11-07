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

        public string Titolo
        {
            get {  return _titolo; }
            set { _titolo = value; }
        }

        public string Autore
        {
           get{ return _autore; }
            set { _autore = value; }
        }

        public float Durata
        {
            get { return _durata; }
            set { _durata = value; }
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

        public override string ToString()
        {
            return _autore + _durata + _titolo;
        }
    }
}
