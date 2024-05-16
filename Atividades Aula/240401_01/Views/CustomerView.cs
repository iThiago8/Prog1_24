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
                Console.WriteLine("4 - Remover Consumidor por Id");
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
                            InsertCustomer();
                        break;
                        case 2:
                            SearchCustomer();
                        break;
                        case 3:
                            ListCustomers();
                        break;

                        case 4:
                            RemoveCustomerById();
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
            Console.WriteLine("");
            Console.WriteLine("***********************");
            Console.WriteLine("INSERIR NOVO CONSUMIDOR");
            Console.WriteLine("***********************");
            Console.WriteLine("");

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
        
        try
        {
        customerController.Insert(customer);
        }
        catch 
        {
            Console.WriteLine("Ocorreu um erro.");
        }

        }

        private void SearchCustomer()
        {    
            int aux = -1;
            do {
                Console.WriteLine("********************");
                Console.WriteLine("PESQUISAR CONSUMIDOR");
                Console.WriteLine("********************");
                Console.WriteLine("");
                
                Console.WriteLine("1 - Buscar por Id");
                Console.WriteLine("2 - Buscar por nome");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("");

                aux = Convert.ToInt32(Console.ReadLine());

                switch(aux)
                {
                    case 0:
                    break;
                    case 1:
                        int id = -1;
                        do {
                            try 
                            {
                                Console.WriteLine("Digite o Id que deseja procurar");
                                id = Convert.ToInt32(Console.ReadLine());
                                ShowCustomerById(id);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Erro: {ex.Message}");
                                id = -1;
                                Console.WriteLine("Opção inválida");
                            }

                        } while (id == -1);
                
                    break;

                    case 2:
                        string name;
                        Console.WriteLine("Digite o nome que deseja procurar");
                        name = Console.ReadLine();
                        ShowCustomersByName(name);

                    break;

                    default:
                        aux = -1;
                        Console.WriteLine("Opção inválida");
                    break;
                } 
            } while (aux != 0);
    

        }
        private void ShowCustomerById(int id)
        {
            Customer? c = customerController.Get(id);
            if (c != null)
            {
                Console.WriteLine(c.ToString());
            }
            else 
            {
                Console.WriteLine("Sua consulta não retornou nenhum resultado.");
            }
        }

        private void ShowCustomersByName(string name)
        {
            List<Customer> result = customerController.GetByName(name);
            if (result == null || result?.Count == 0)
            {
                Console.WriteLine("Não encontrado!");
                return;
            }

            foreach (var c in result)
            {
                Console.WriteLine(c.ToString());
            }
        
            
        }

        private void ListCustomers()
        {
            List<Customer> result = customerController.Get();
            if (result == null || result?.Count == 0)
            {
                Console.WriteLine("Não existem consumidores!");
                return;
            }

            foreach (var c in result)
            {
                Console.WriteLine(c.ToString());
            }
        }

        private void RemoveCustomerById()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("REMOVER CONSUMIDOR POR ID");
            Console.WriteLine("*************************");
            Console.WriteLine("");

            int id;
            do{
                try 
                {
                    Console.WriteLine("Digite o Id do consumidor que deseja remover:");
                    id = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Valor inserido inválido.");
                    id = -1;
                }

            } while (id == -1);

            ShowCustomerById(id);
            Customer c = customerController.Get(id);

            Console.WriteLine("Deseja mesmo remover o consumidor acima?");

            int aux;
            do{
                
                try 
                {
                    Console.WriteLine("1 - Sim:");
                    Console.WriteLine("2 - Não:");
                    aux = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Valor inserido inválido.");
                    aux = -1;
                }

            } while (aux == -1);

            if (aux == 1)
            {
                customerController.Remove(c);
            }
        }
    }
}