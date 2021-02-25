using System;
using System.Collections.Generic;
using System.Text;

namespace Recayd
{
    public class Atirador : Personagem
    {

        public Atirador()
        {
            Nome = "Igu";
            Hp = 400;
            Dano = 70;
            Level = 0;
        }


        private int Movimento { get; set; }

        public override void ResolverTurno(Personagem Inimigo)
        {

            Console.WriteLine("Digite (1) para atacar ; Digite (2) para curar");
            this.Movimento = int.Parse(Console.ReadLine());

            if (Movimento == 1)
            {
                Console.WriteLine(this.Nome +"Deu um tiro de bazuka no peito do inimigo" + this.Dano);
                Inimigo.Hp -= this.Dano;
            }

            else if (Movimento == 2)
            {
                Console.WriteLine(this.Nome + "Cura +100");
                this.Hp += 100;
            }


        }


    }
}
