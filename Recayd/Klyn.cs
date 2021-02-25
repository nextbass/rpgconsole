using System;
using System.Collections.Generic;
using System.Text;

namespace Recayd
{
    public class Klyn : Personagem
    {
        public Klyn()
        {
            Nome = "Klyn";
            Hp = 225;
            Dano = 50;
        }
        private int EnergiaAtk;

        public override void ResolverTurno(Personagem Inimigo)
        {

            if (EnergiaAtk % 2 == 0)
            {
                Console.WriteLine(this.Nome + "Ataque Especial" + this.Dano * 1.5);
                Inimigo.Hp = Inimigo.Hp - Convert.ToInt32(this.Dano * 1.5);
                EnergiaAtk++;
            }
            else
            {
                base.ResolverTurno(Inimigo);
            }
        }

    }

}

