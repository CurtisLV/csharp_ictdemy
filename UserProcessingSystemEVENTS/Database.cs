using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProcessingSystemEVENTS;

internal class Database
{
    public void SaveToDB(object sender, EventArgs e)
    {
        Console.WriteLine("Data saved to database!");
    }
}
