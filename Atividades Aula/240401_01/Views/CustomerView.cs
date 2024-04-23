using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01.Views
{
    public class CustomerView
    {
        public CustomerView()
        {
            this.Init();
        }    
        public void Init()
        {
            Console.WriteLine("");
            Console.WriteLine("******************");
            Console.WriteLine("MENU DE CONSUMIDORES");
            Console.WriteLine("******************");
            Console.WriteLine("");

            bool aux = true;
            do {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Consumidor");
                Console.WriteLine("2 - Pesquisar Consumidor");
                Console.WriteLine("3 - Listar Consumidores");
                Console.WriteLine("0 - SAIR");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 0:
                            aux = false;
                        break;
                        case 1:
                        break;
                        case 2:
                        break;
                        case 3:
                        break;
                        default:
                        break;
                    }
                

                    
                        
                }
                catch
                {
                    Console.WriteLine("Opção inválida");
                    menu = -1;
                }

                

            } while(aux);
        }
    }
}