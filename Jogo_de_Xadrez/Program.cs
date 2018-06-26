using System;
using Tabuleiro;

namespace Jogo_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;

           p = new Posicao(3,4);

           Console.WriteLine("Posição: "+ p);
        }
    }
}
