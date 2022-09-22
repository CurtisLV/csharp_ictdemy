using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events;

internal class Order
{

    public enum EState
    {
        Unconfirmed, Confirmed, Shipped, Delivered
    }

    public EState State { get; private set; }
    private EState oldState;

    public string Product { get; private set; }


}
