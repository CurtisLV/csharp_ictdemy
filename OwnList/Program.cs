using OwnList;

MyList myList = new MyList();

myList.Add(1);
myList.Add("second");

for (int i = 3; i < 2000; i++)
{
    myList.Add(i);
}

myList[3] = "Fourth";


