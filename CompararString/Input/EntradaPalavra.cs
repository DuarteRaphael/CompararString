using CompararString.Entities;
using CompararString.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CompararString.Input
{
    public class EntradaPalavra
    {
        public string LerPalavra2()
        {
            Console.Write("Encrava a palavra 2: ");
            Palavra pa2 = new Palavra();
            pa2.Palavra1 = Console.ReadLine();
        }
    }
}
