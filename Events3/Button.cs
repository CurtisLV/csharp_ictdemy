using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events3;

internal class Button
{
    public event EventHandler ButtonClicked;
    protected virtual void OnClick()
    {
        ButtonClicked.Invoke(this, EventArgs.Empty);
    }
}
