using FactorySweets;

for (int i = 0; i < 5; i++)
{
    Sweet sweet = SweetsFactory.CreateBanana();
    Console.WriteLine(sweet);
}

for (int i = 0; i < 8; i++)
{
    Sweet sweet = SweetsFactory.CreateStrawberry();
    Console.WriteLine(sweet);
}

for (int i = 0; i < 12; i++)
{
    Sweet sweet = SweetsFactory.CreateChocolate();
    Console.WriteLine(sweet);
}
