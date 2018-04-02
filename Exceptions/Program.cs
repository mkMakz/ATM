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
            try
            {
                List<Client> ListClient = new List<Client>();
                GeneratorName.Generator gn = new Generator();
                Client client = new Client();
                client.DoB = DateTime.Now.AddYears(-60);
                client.FullName = gn.GenerateDefault(Gender.man);
                client.IIN = "123456789123";
                client.Login = "Qwerty";
                client.Password = "123";
                client.PhoneNumber = "87651684585";
                ListClient.Add(client);

            }
            catch(System.Net.WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
