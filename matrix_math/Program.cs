//Задание 4
//Создайте приложение, которое производит операции 
//над матрицами:
//■  Умножение матрицы на число;
//■  Сложение матриц;
//■  Произведение матриц.

int sizeR = 5;
int sizeC = 5;
int minRandom = 1;
int maxRandom = 10;
Random random = new Random();
int[,] arr = new int[sizeR, sizeC];
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        arr[i, j] = random.Next(minRandom, maxRandom);
    }
}
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Sum of 2 matrix");
int[,] arr2 = new int[sizeR, sizeC];
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        arr2[i, j] = arr[i, j] + arr[i, j];
        Console.Write($"{arr2[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Multiply of 2 matrix");
int[,] arr3 = new int[sizeR, sizeC];
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        arr3[i, j] = arr[i, j] * arr[i, j];
        Console.Write($"{arr3[i, j]}\t");
    }
    Console.WriteLine();
}

int[,] arr4 = arr;
Console.WriteLine("input number to multiply");
int num = int.Parse(Console.ReadLine());
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        arr4[i, j] *= num;
        Console.Write($"{arr4[i, j]}\t");
    }
    Console.WriteLine();
}