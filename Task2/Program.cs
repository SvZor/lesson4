// способы создания двумерного массиа
// первый
// int[,] table1 = new int[2, 4]{
//     {1,1,1,1},
//     {2,2,2,2}
// };

// // второй
// int[,] table2 = new int[,] {  // не указываетсся количество строк и столбцов
//     {1,1,1,1},
//     {2,2,2,2}
// };

// // третий когда new int не указывается
// int[,] table3 = {
//     {1,1,1,1},
//     {2,2,2,2}
// };
// задача 2
// назовем число "интересным" если его сумма цифр четная
// создать двумерный массив, состоящий их целых чисел. 
// вывести на экран "интересные" элементы массива

int[,] CreateMatrix(int rowCount, int columsCount) // функция создания массива
// из рандомных цифр
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} "); // интерполяция строк"${matrix[i, j]} "
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3,4); // создание двумерного массива
// с заданным числом строк и столбцов
ShowMatrix(matrix);
foreach (int e in matrix) // цикл проверки массива 
// не меняет элементы массива
{
    if (IsInteresting(e) == true)
    {
        Console.Write(e);
        Console.Write(" ");
    }
}

bool IsInteresting(int value) // проверяем на интересность
{
    int SumOfDigits = GetSumOfDigits(value);
    if (SumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}
int GetSumOfDigits (int  value)
{
    int sum = 0;
    while(value > 0) // зациклили сумму цифр числа
    {
        sum = sum +  value % 10; // к сумме прибавляем остаток от деления на 10
        value = value / 10;
    }
    return sum;
}
