using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperNameSpace;

namespace Bank_Project
{
    class BankCard
    {
        public string BankName { get; set; }

        public string UserName { get; set; }

        public string PAN { get; set; }

        public string PIN { get; set; }

        public string CVC { get; set; }

        public DateTime ExpireTime { get; set; }

        public int Balance { get; set; }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance : {Balance}");
        }

    }
    class Client
    {
        BankCard bankCard;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public void Show()
        {
            Console.WriteLine("==========CLIENT==========");
            Console.WriteLine();
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Salary : {Salary}");
            Console.WriteLine($"ID : {Id}");
        }

    }
    class Bank
    {
        public int ClientCount { get; set; }

        public Client[] Clients { get; set; }
        public void addClients(ref Client client)
        {
            Client[] temp = new Client[++ClientCount];
            if (Clients != null)
            {
                Clients.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = client;
            Clients = temp;


        }
        public BankCard bankCard { get; set; } = default;
        public void ShowCardBalance(BankCard BankCard)
        {
            try
            {
                if (Hepler.CheckPAN(BankCard.PAN))
                {
                    if (Hepler.CheckExpireTime(BankCard.ExpireTime))
                    {
                        if (Hepler.CheckBalance(BankCard.Balance))
                        {
                            bankCard.ShowBalance();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ShowClients()
        {
            foreach (var item in Clients)
            {
                item.Show();
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            BankCard bankCard1 = new BankCard
            {
                BankName = "Bir Bank",
                UserName = "Obama Obamali",
                PIN = "1234",
                PAN = "321245",
                CVC = "343",
                ExpireTime = new DateTime(2023,12,10),
                Balance = 12340
            };
            
            Client c1 = new Client
            {
                Name = "Obama",
                Surname = "Obamali",
                Age = 45,
                Id = 1,
                Salary = 1200
            };
            Client c2 = new Client
            {
                Name = "Nizami",
                Surname = "Nizamili",
                Age = 35,
                Id = 2,
                Salary = 2100
            };
            Client c3 = new Client
            {
                Name = "John",
                Surname = "Johnoglu",
                Age = 25,
                Id = 12,
                Salary = 4500
            };

            Bank bank = new Bank { };
            bank.addClients(ref c1);
            bank.addClients(ref c2);
            bank.addClients(ref c3);

            bank.ShowClients();

            bank.ShowCardBalance(bankCard1);
            
        }
    }
}

