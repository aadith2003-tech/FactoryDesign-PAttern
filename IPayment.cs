using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//******************************** Defines an interface for creating an object, but lets subclasses alter the type of objects that will be created.********************************///////
namespace Factory_Design_pattern
{
    public interface IPayment
    {
        void pay(Double amount);
    }
}
