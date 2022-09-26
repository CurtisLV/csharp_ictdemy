using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProcessingSystemEVENTS;

public class IdCardGenerator
{
    public void GenerateIdCard(object sender, EventArgs e)
    {
        Guid id = Guid.NewGuid();
        Console.WriteLine($"ID card generated: {id}");
    }
}
