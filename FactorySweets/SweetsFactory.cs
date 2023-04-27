using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySweets;

internal class SweetsFactory
{
    public static Sweet CreateBanana()
    {
        return new Sweet("yellow", "round", 15);
    }

    public static Sweet CreateStrawberry()
    {
        return new Sweet("red", "round", 15);
    }

    public static Sweet CreateChocolate()
    {
        return new Sweet("brown", "square", 25);
    }
}
