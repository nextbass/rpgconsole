using System;
using System.Collections.Generic;
using System.Text;

namespace Recayd
{
    public class BcRaff : Personagem
    {

        public BcRaff()
        {

            this.Nome = "Raffa Moreira Mano";
            this.Hp = 300;
            this.Dano = 75;
            
        }

        private int EnergiaAtk;
       

        public override void ResolverTurno (Personagem Inimigo)
        {

            if (EnergiaAtk % 2 == 0)
            {

                Console.WriteLine(this.Nome + "Ataque de Você é branco bro" + this.Dano * 1.5);
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
