string[] a = new string[21];
for (int i = 0; i < a.Length; i++)
{
    a[i] = $"a{i+1}";
}

string[,] b = new string[6, 6];
for (int i = 0; i < b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        b[i, j] = "0";
    }
}

int last_element = 0;

for (int i = 0; i < b.GetLength(1); i++)
{
    int att = i + 1;

    for (int j = 0; j < att; j++)
    {
        b[i, j] = a[last_element + j];
    }
    last_element += att;
}

Console.WriteLine("Массив A:");
PrintArray(a);
Console.WriteLine("\nМассив B:");
PrintMatrix(b);
Console.WriteLine("\nИнвертированный массив B:");
PrintReversedMatrix(b);
Console.WriteLine("\nПо-другому инвертированный массив B:");
PrintReversedMatrix2(b);




void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write(array[i]);
        else
            Console.Write(array[i] + ", ");
    }
    Console.WriteLine("]");
}

void PrintMatrix(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write("│");
            Console.Write(" {0, 3} ", array[i, j]);
            if (j == array.GetLength(1) - 1)
                Console.Write("│");
        }
        Console.WriteLine();
    }
}

void PrintReversedMatrix(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (j == array.GetLength(1) - 1)
                Console.Write("│");
            Console.Write(" {0,3} ", array[i, j]);
            if (j == 0)
                Console.Write("│");
        }
        Console.WriteLine();
    }
}

void PrintReversedMatrix2(string[,] array)
{
    for (int i = array.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (j == array.GetLength(1) - 1)
                Console.Write("│");
            Console.Write(" {0,3} ", array[i, j]);
            if (j == 0)
                Console.Write("│");
        }
        Console.WriteLine();
    }
}