using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRun;

internal class CSharpProgrammer : Human
{
    private string ide;

    public CSharpProgrammer(string name, int age, string ide)
        : base(name, age)
    {
        this.ide = ide;
    }

    public void Program(int lines)
    {
        int lineAmnt = (int)Math.Round(lines / 10d);
        if (tiredness + lineAmnt > 20)
        {
            Console.WriteLine("I'm too tired to program");
        }
        else
        {
            tiredness = tiredness + lineAmnt;
        }
    }
}
