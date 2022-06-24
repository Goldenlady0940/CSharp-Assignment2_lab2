// See https://aka.ms/new-console-template for more information
int i, j;

Console.WriteLine("Multiplication Table\n");
Console.WriteLine("Enter your table size");

int size = Convert.ToInt32(Console.ReadLine());

if(size == 0)
{
    Console.WriteLine("Please enter number greater than one: ");
    size = Convert.ToInt32(Console.ReadLine());
}
else
{
    for (i = 1; i <= size; i++)
    {
        for (j = 1; j <= size; j++)
        {
            Console.Write(i * j + "\t");
        }
        Console.Write("\n");
    }
}

