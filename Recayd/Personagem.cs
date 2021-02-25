using System;
using System.Collections.Generic;
using System.Text;

namespace Recayd
{
    public class Personagem
    {

        public string Nome { get; set; }
        public int Hp { get; set; }
        public int Dano { get; set; }
        public int Level { get; set; }
        public int FaccaoEscolhida { get; set; }



        public virtual void ResolverTurno(Personagem Inimigo)
        {
            Console.WriteLine(this.Nome + ": Ataque normal - " + this.Dano);
            Inimigo.Hp = Inimigo.Hp - this.Dano;
        }



    }


    

}
