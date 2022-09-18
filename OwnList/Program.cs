using OwnList;

MyList myList = new MyList();

myList.Add(1);
myList.Add("Second");

for (int i = 3; i < 2000; i++)
{
    myList.Add(i);
}

myList[3] = "Fourth";

for (int i = 0; i < 100; i++)
{
    Console.WriteLine(myList[i]);
}
