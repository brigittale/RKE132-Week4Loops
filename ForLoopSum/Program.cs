

int sum = 0;

for(int i = 1; 1 < 11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i;
}


Console.WriteLine($"Final total {sum}");