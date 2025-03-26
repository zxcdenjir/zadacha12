int[] a = new int[21];
for (int i = 0; i < a.Length; i++)
{
    a[i] = i + 1;
}

int[,] b = new int[6, 6];
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
Console.WriteLine("\nМассив B");
PrintMatrix(b);
Console.WriteLine("\nИнвертированный массив B");
PrintReversedMatrix(b);
Console.WriteLine("\nПо-другому инвертированный массив B");
PrintReversedMatrix2(b);




void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintMatrix(int[,] array)
{
    int maxNumberLength = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            maxNumberLength = Math.Max(maxNumberLength, array[i, j].ToString().Length);
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write("│ ");
            Console.Write("{0," + maxNumberLength + "} ", array[i, j]);
            if (j == array.GetLength(1) - 1)
                Console.Write("│");
        }
        Console.WriteLine();
    }
}

void PrintReversedMatrix(int[,] array)
{
    int maxNumberLength = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            maxNumberLength = Math.Max(maxNumberLength, array[i, j].ToString().Length);
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (j == array.GetLength(1) - 1)
                Console.Write("│ ");
            Console.Write("{0," + maxNumberLength + "} ", array[i, j]);
            if (j == 0)
                Console.Write("│");
        }
        Console.WriteLine();
    }
}

void PrintReversedMatrix2(int[,] array)
{
    int maxNumberLength = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            maxNumberLength = Math.Max(maxNumberLength, array[i, j].ToString().Length);
        }
    }

    for (int i = array.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (j == array.GetLength(1) - 1)
                Console.Write("│ ");
            Console.Write("{0," + maxNumberLength + "} ", array[i, j]);
            if (j == 0)
                Console.Write("│");
        }
        Console.WriteLine();
    }
}