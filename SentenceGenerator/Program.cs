using SentenceGenerator;

SentenceGen words = new SentenceGen();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(words.Generate());
}
