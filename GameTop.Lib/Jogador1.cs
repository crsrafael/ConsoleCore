using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : IJogador
    {
        public string Nome { get; set; }

        public Jogador1(string nome)
        {
            Nome = nome;
        }
        //Chuta
        public string Chuta()
        {
            return $"{Nome} está chutando";
        }

        //Corre
        public string Corre()
        {
            return $"{Nome} está correndo";
        }

        //Passa
        public string Passa()
        {
            return $"{Nome} está passando";
        }
    }
}