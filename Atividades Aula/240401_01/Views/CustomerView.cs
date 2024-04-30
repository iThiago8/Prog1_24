using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Controllers;

namespace _240401_01.Views
{
    public class CustomerView
    {
        private CustomerController customerController;
        private AddressView addressView;
        public CustomerView()
        {
            addressView = new AddressView();
            customerController = new CustomerController();
            this.Init();
        }    
        public void Init()
        {
            Console.WriteLine("");
            Console.WriteLine("********************");
            Console.WriteLine("MENU DE CONSUMIDORES");
            Console.WriteLine("********************");
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
            } while (aux);
        }

        private void InsertCustomer()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("INSERIR NOVO CONSUMIDOR");
            Console.WriteLine("***********************");

            Customer customer = new Customer();

            Console.WriteLine("Nome:");
            customer.Name = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Email:");
            customer.EmailAddress = Console.ReadLine();
            Console.WriteLine("");

            int aux = 0;
        
            Console.WriteLine("Deseja informar um endereço?:");
            do {
                Console.WriteLine("0 - Não");
                Console.WriteLine("1 - Sim");

                try
                {
                    aux = Convert.ToInt32(Console.ReadLine());
                }
                catch 
                {
                    aux = 1;
                    Console.WriteLine("Opção inválida");
                }

                if (aux == 1)
                {
                    customer.Addresses.Add(addressView.Insert());
                }
                else if (aux == 0)
                    break;
                else 
                {
                    aux = 1;
                    Console.WriteLine("Opção inválida");
                    Console.WriteLine("Tente Novamente:");

                }
                
                
            } while (aux != 0);


        }
    }
}