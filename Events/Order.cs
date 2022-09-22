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

    public event EventHandler StateChanged;

    public Order( string product)
    {
        State = EState.Unconfirmed;
        oldState = State;
        Product = product;
    }

    protected void OnStateChanged(EventArgs e)
    {
        if (State != oldState)
        {
            StateChanged(this, e);
        }
    }

    public void ChangeState(EState state)
    {
        oldState = State;
        State = state;
        OnStateChanged(EventArgs.Empty);
    }

    public override string ToString()
    {
        return Product + " order";
    }
}
