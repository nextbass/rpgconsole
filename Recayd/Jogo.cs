using System;
using System.Collections.Generic;
using System.Text;

namespace Recayd
{
    public class Jogo
    {

        public Personagem Heroi;
        public int FaccaoEscolhida;
        public int ExpedicaoGo;
        public int Jornada = 0;
        public Personagem InimigoAtual;
        public int FaseCount = 0;
        public int InimigosCount = 0;
        public Personagem HeroiAtual;
        

        
        public void Iniciar()
        {
            Heroi = new Personagem();
            Console.WriteLine("Bem vindo forasteiro, qual o teu nome?");
            Heroi.Nome = Console.ReadLine();
            EscolherFaccao();
            Console.WriteLine("Vamos para luta então!!");
            Expedicao();



        }
        private void EscolherFaccao()
        {
            Console.WriteLine("Olá " + Heroi.Nome + "A qual Faccao você pertence?");
            Console.WriteLine("Digite (1) para Atirador ; Digite (2) para Lutador;");
            FaccaoEscolhida = int.Parse(Console.ReadLine());
            if (FaccaoEscolhida == 1)
            {

                Heroi = new Atirador();
                HeroiAtual = Heroi;
                Console.WriteLine("Ficamos felizes em ter um bravo Atirador!!");


            }
            else if (FaccaoEscolhida == 2)
            {
                Heroi = new Lutador();
                HeroiAtual = Heroi;
                Console.WriteLine("Ficamos feliz em ter um bravo lutador!!");
            }


        }
        private void Expedicao()
        {

            Console.WriteLine("Digite (1) para buscar monstros; Digite (2) para sair;");
            ExpedicaoGo = int.Parse(Console.ReadLine());

            if (ExpedicaoGo == 1)
            {

                BuscarMonstros();

            }

            else if (ExpedicaoGo == 2)
            {

                Console.WriteLine("Caminhe pelas sombras bravo forasteiro, você agora faz parte de nós.");
                Console.WriteLine("Obrigado por nos ajudar a derrotar " +InimigosCount + " inimigos!!");

            }

        }
        private void BuscarMonstros()

        {
            if (Jornada == 0)
            {
                Heroi = HeroiAtual;
                InimigoAtual = new Klyn();
                Batalhar();
                

            }
            else if (Jornada == 1)
            {
                Console.WriteLine("Você andou mais um pouco e encontrou um novo inimigo, boa sorte em sua batalha!!");
                Heroi = HeroiAtual;
                InimigoAtual = new Klyn();
                Batalhar();

            }

            else if (Jornada == 2 )
            {

                Console.WriteLine("Você andou mais um pouco e encontrou um novo inimigo, boa sorte em sua batalha!!");
                Heroi = HeroiAtual;
                InimigoAtual = new BcRaff();
                Batalhar();
            }
            else
            {
                Console.WriteLine("Você batalhou bravamente, obrigado por nos ajudar a derrotar nossos inimigos");
                Console.WriteLine("Deseja continuar patrulhando?");
                Console.WriteLine("Digite (1) para sim; Digite (2) para não;");
                ExpedicaoGo = int.Parse(Console.ReadLine());
                Jornada = 0;
                BuscarMonstros();

            }
        }
        public bool Batalhar()
        {
            while (HeroiAtual.Hp > 0 && InimigoAtual.Hp > 0)
            {

                Console.WriteLine("Turno " + FaseCount + " J: " + HeroiAtual.Nome + "- HP: " + HeroiAtual.Hp + " Lv: " + HeroiAtual.Level + " NPC: " + InimigoAtual.Nome + "- HP: " + InimigoAtual.Hp);
                HeroiAtual.ResolverTurno(InimigoAtual);
                InimigoAtual.ResolverTurno(HeroiAtual);
                Console.WriteLine("Fim do turno - press any key to continue");
                Console.WriteLine();
                Console.ReadKey();
                FaseCount++;
                VerificaBatalha();
               
               

            }

            if (Heroi.Hp > 0)
          
            return true;
            return false;

            
            }
        private void VerificaBatalha()
        {
            if (InimigoAtual.Hp <= 0)
            {

                Console.WriteLine("Deseja continuar batalhando ou sair fora?");
                Console.WriteLine("Digite (1) para continuar batalhando; Digite (2) para ir descansar;");
                ExpedicaoGo = int.Parse(Console.ReadLine());

                if (ExpedicaoGo == 1)
                {
                    Jornada++;
                    InimigosCount++;
                    FaseCount = 0;
                    BuscarMonstros();
                }

                else
                {
                    Console.Clear();
                    InimigosCount++;
                    Console.WriteLine("Caminhe pelas sombras bravo forasteiro, você agora faz parte de nós.");
                    Console.WriteLine("Obrigado por nos ajudar a derrotar " + InimigosCount + " inimigos!!");
                }



            }
        }

    }
}
