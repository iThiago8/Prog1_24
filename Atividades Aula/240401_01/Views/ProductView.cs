using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Controllers;
using _240401_01.Repository;
using _240104_01.Controllers;

namespace _240401_01.Views
{
    public class ProductView
    {
        private ProductController productController;
        public ProductView()
        {
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine("MENU DE PRODUTOS");
            Console.WriteLine("****************");
            Console.WriteLine();
    
            bool aux = true;
            do {
                Console.WriteLine("1 - Inserir Produto");
                Console.WriteLine("2 - Pesquisar Produto");
                Console.WriteLine("3 - Listar Produtos");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine();

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
                            InsertProduct();
                        break;
                        case 2:
                            
                        break;
                        case 3:

                        break;
                        default:
                            Console.WriteLine("Opção inválida");
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

        private void InsertProduct()
        {
            Console.WriteLine("");
            Console.WriteLine("********************");
            Console.WriteLine("INSERIR NOVO PRODUTO");
            Console.WriteLine("********************");
            Console.WriteLine("");

            Product product = new();

            Console.WriteLine("Nome:");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("");
            
            Console.WriteLine("Descrição do produto (opcional)");
            product.Description= Console.ReadLine();

            Console.WriteLine("Valor do produto");

            int aux;
            do {
                try 
                {
                    product.CurrentPrice = float.Parse(Console.ReadLine());        
                    aux = 1;
                }
                catch
                {
                    Console.WriteLine("Valor inválido. Insira o valor novamente:");
                    aux = -1;
                }
            } while (aux == -1);

            try 
            {
                productController.Insert(product);
            }
            catch 
            {
                Console.WriteLine("Ocorreu um erro. Tente novamente mais tarde");
            }
        }



    }
}