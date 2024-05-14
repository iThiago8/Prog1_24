using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Repository;
using _240401_01.Controllers;
using _240401_01.Models;

namespace _240401_01.Views
{
    public class AddressView
    {
        private AddressController addressController;

        public AddressView()
        {
            addressController = new AddressController();
            this.Init();
        }

        private void Init()
        {
        }

        public Address Insert()
        {
            Address address = new Address();
            Console.WriteLine("************************");
            Console.WriteLine("INSERIR UM NOVO ENDEREÇO");
            Console.WriteLine("************************");

            Console.WriteLine("Qual o tipo do endereço?");
            Console.WriteLine("0 - CANCELAR");
            Console.WriteLine("1 - Residencial");
            Console.WriteLine("2 - Comercial");
            Console.WriteLine("3 - Outros");

            int aux = 0;
            do {
                try
                {
                    aux = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    aux = -1;
                    Console.WriteLine("Opção inválida");
                    Console.WriteLine("Tente novamente");

                }
            } while (aux == -1);

            switch (aux)
            {
                case 0:
                
                    break;
                case 1:
                    address.Type = AddressType.Residential;
                break;

                case 2:
                    address.Type = AddressType.Commercial;
                break;

                case 3:
                    address.Type = AddressType.Other;
                break;

                default:
                    Console.WriteLine("Opção inválida");
                break;
            }

            Console.WriteLine("Rua:");
            address.Street = Console.ReadLine();

            Console.WriteLine("Bairro:");
            address.District = Console.ReadLine();

            Console.WriteLine("CEP:");
            address.ZipCode = Console.ReadLine();
            
            Console.WriteLine("Cidade:");
            address.City = Console.ReadLine();

            Console.WriteLine("Estado:");
            address.FederalState = Console.ReadLine();

            Console.WriteLine("País:");
            address.Country = Console.ReadLine();

            Console.WriteLine("Endereço padrão?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int isDefault = Convert.ToInt32(Console.ReadLine());
            address.isDefault = isDefault == 1 ? true : false;

            Console.WriteLine("Deseja inserir um novo endereço?");
            addressController.Insert(address);

            return address;
        }

        public void ShowAddresses()
        {
            List<Address> result = addressController.Get();
            if (result == null || result?.Count == 0)
            {
                return;
            }

            foreach (var a in result)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }

    
}