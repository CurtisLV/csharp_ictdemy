﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProcessingSystemEVENTS;

public class EmailGen
{
    public void SendEmail(object sender, EventArgs e)
    {
        Console.WriteLine("Email sent!");
    }
}
