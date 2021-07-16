using System;
using GameTop.Lib;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly Jogador1 _jogador1;

        private readonly Jogador2 _jogador2;
        
        public JogoFoda(Jogador1 jogador1, Jogador2 jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void InicarJogo()
        {
            Console.WriteLine(_jogador1.Chuta());
            Console.WriteLine(_jogador1.Corre());
            Console.WriteLine(_jogador1.Passa());

            Console.WriteLine("PRÓXIMO JOGADOR");

            Console.WriteLine(_jogador2.Chuta());
            Console.WriteLine(_jogador2.Corre());
            Console.WriteLine(_jogador2.Passa());
        }
    }
}