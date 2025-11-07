using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace riproduzione_musicale
{
    internal class Cd
    {
        private string _titolo;
        private string _autore;
        private List<string> _listaDiBrani;
        public Cd(string titolo, string autore, List<string> listaDiBrani)
        {
            _titolo = titolo;
            _autore = autore;
            _listaDiBrani = listaDiBrani;


        }

        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }
        public string Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }

  
        
        
    }
} 

