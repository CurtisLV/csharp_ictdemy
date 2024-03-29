﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnList;

internal class MyList
{
    private object[] items = new object[10];

    public int Count { get; private set; }

    public object this[int i]
    {
        get { return items[i]; }
        set { items[i] = value; }
    }

    public void Add(object item)
    {
        items[Count] = item;
        Count++;

        if (Count == items.Length)
        {
            object[] items2 = new object[Count * 2];
            items.CopyTo(items2, 0);
            items = items2;
        }
    }
}
