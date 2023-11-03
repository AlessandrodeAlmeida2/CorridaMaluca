using System;
using System.Diagnostics.Eventing.Reader;
using System.Threading;

namespace RacingGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Corredor c1 = new Corredor();

            Console.WriteLine("Digite seu nome: ");
            string n = Console.ReadLine();
            Pista pista1 = new Pista(100, new Corredor(n));
            Pista pista2 = new Pista(100, new Corredor("f"));
            Pista pista3 = new Pista(100, new Corredor("d"));

            string resp = "s";
            while (resp == "s")
            {
                Console.WriteLine("Corrida Maluca");
                Boolean ganhou = false;
                ganhou = false;
                int ganhador = 0;
                while (ganhou == false)
                {
                    Console.Clear();
                    if (pista1.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 1;
                    }
                    else if (pista2.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 2;
                    }
                    else if (pista3.AtualizarCorrida() == true)
                    {
                        ganhou = true;
                        ganhador = 3;
                    }
                    else
                    {
                        ganhador = 4;
                    }

                    pista1.ExibirPista();
                    pista2.ExibirPista();
                    pista3.ExibirPista();

                    //Console.ReadKey();
                    Thread.Sleep(1000);
                }
                Console.Clear();
                Console.WriteLine(" O Ganhador foi!!!!!");
                switch (ganhador)
                {
                    case 1:
                        Console.WriteLine("Parabéns!!! Você ganhou!!!");
                        break;
                    case 2:
                        Console.WriteLine("O corredor \"f\" ganhou!!!");
                        break;
                    case 3:
                        Console.WriteLine("O corredor \"d\" ganhou!!!");
                        break;
                    default:
                        Console.WriteLine("Empate!!!");
                        break;
                }
                Console.Write("Gostaria de jogar novamente (s ou n: ");
                Console.ReadLine().ToLower();
            }
        }
    }
}
