using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2;

internal class ButtonMaster
{
    public event EventHandler? ButtonPressed;

    public void OnButtonPress(char keyCode)
    {
        ButtonPressed?.Invoke(this, EventArgs.Empty);
    }

}
