using System;
using System.Collections.Generic;
using System.Text;

namespace Recayd
{
    public class Lutador : Personagem
    {

        public Lutador()
        {
            Nome = "Dfideliz";
            Hp = 350;
            Dano = 75;
            Level = 0;
        }

        private int Movimento { get; set; }

        public override void ResolverTurno(Personagem Inimigo)
        {
            Console.WriteLine("Digite (1) para Atacar // (2) para recuperar hp");
            this.Movimento = int.Parse(Console.ReadLine());

            if (Movimento == 1)
            {
                Console.WriteLine(this.Nome + "Deu uma espadada e arregaçou o inimigo" + this.Dano);
                Inimigo.Hp -= this.Dano;
            }

            else if (Movimento == 2)
            {
                Console.WriteLine(this.Nome + "Cura +100 hp");
                this.Hp += 100;

            }


        }


    }
}