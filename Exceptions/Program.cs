using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KKB.Bank.Module;
using GeneratorName;


namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string Login = "";
            string Password = "";

            try
            {
                Client cl = new Client();
                Service.CreateClient(ref cl);
                cl.Login = "admin";
                cl.Password = "admin";

                while (!cl.isBlocked)
                {
                    Console.Clear();
                    Console.Write("Sign in \n");
                    Login = Console.ReadLine();
                    Console.Write("Enter a password \n");
                    Password = Console.ReadLine();

                    if (Login != cl.Login && Password != cl.Password)
                        cl.WrongField++;
                    else
                        break;
                }


                if (Login == cl.Login && Password == cl.Password)
                {
                    if (cl.isBlocked)
                    {
                        Console.WriteLine("User blocked! ");
                    }
                    else
                    {
                        #region
                        Console.Clear();

                        Console.WriteLine("1. Checks lists");
                        Console.WriteLine("2. Create a check");
                        Console.WriteLine("3. Add to balance");
                        int MenuChoice = 0;
                        Int32.TryParse(Console.ReadLine(), out MenuChoice);
                        if (MenuChoice > 2 || MenuChoice < 1)
                        {
                            throw new Exception("Invalid choice");
                        }
                        else
                        {
                            switch (MenuChoice)
                            {
                                case 1:
                                    {
                                        cl.PrintAccount();
                                    }
                                    break;
                                case 2:
                                    {
                                      Account acc = Service.CreateAccountList();
                                        cl.ListAccount.Add(acc);
                                        Console.WriteLine("Your check was succesfully added!");
                                    }
                                    break;
                                case 3:
                                    {
                                        ;
                                        Console.WriteLine("Enter your check number ");
                                        string accountNumber = Console.ReadLine();
                                        Console.WriteLine();

                                        //KZ621044
                                    }
                                    break;
                            }
                        }
                        #endregion
                    }
                }
                else
                {
                    Console.WriteLine("User blocked!");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            /* List<Client> ListClient = new List<Client>();
                 GeneratorName.Generator gn = new Generator();
                 Client client = new Client();
                 client.DoB = DateTime.Now.AddYears(-60);
                 client.FullName = gn.GenerateDefault(Gender.man);
                 client.IIN = "123456789123";
                 client.Login = "Qwerty";
                 client.Password = "123";
                 client.PhoneNumber = "87651684585";
                 ListClient.Add(client);*/


        }
    }
}