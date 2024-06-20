using CompararString.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararString.Entities
{
    public class Palavra : IPalavra
    {
        public string Palavra1 { get; set; }
        public string Palavra2 { get; set; }
    }
}
