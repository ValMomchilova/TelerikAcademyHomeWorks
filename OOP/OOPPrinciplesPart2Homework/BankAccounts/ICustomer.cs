using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public interface ICustomer
    {
        CustomerType CustomerType { get; }

        string Name { get;}

        string Address { get; set; }

        string PhoneNumber { get; set; }
    }
}
