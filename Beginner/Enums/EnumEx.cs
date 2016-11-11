using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class EnumEx
    {
        static void Main(string[] args)
        {
            //Data type - represents name/value pairs
            //Use type casting to interconvert
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var newMethod = 3;
            Console.WriteLine((ShippingMethod)newMethod);

            Console.WriteLine(method.ToString());

            //string to enum
            var methodName = "Express";
            var shipMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shipMethod);
        }
    }

    //Name/value pairs
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
}
