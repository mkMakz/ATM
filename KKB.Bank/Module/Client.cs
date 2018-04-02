using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KKB.Bank.Module
{
    public class Client
    {
        public Client()
        {
            ListAccount = new List<Account>();
        }

      public string FullName { get; set; }

        private string IIN_;

      public string IIN {
            get
            {
                return IIN_;
            }
            set { if (value.Length == 12)
                {
                    IIN_ = value;

                }
            else
                {
                    throw new Exception("Invalid sequence of IIN");

                }

            }

        }   
        public DateTime DoB { get; set; }

    public string PhoneNumber { get; set; }

        public string Login { get;  set; }
        public string Password { get; set; }

        List<Account> ListAccount;


    }
}
