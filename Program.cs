// Урок 7. Как не нужно писать код. Часть 1
Console.WriteLine("Урок 7. Как не нужно писать код. Часть 1\n");
Console.WriteLine("Задачи урока 7 выполнены в виде единой задачи, в которой");
Console.WriteLine("создается массив вводимой размерности, по запросу выводится на экран, ");
Console.WriteLine("по запросу вводится номер столбца/строки и определяется наличие элемента с такими индексами, ");
Console.WriteLine("по запросу вычисляется среднее арифметическое столбцов массива \n");


// "Методы Урока 7 - создание массива заданной размерности и вывод его на экран

//Создание двумерного массива типа double
double[,] CreateArrayDoubleTwoDim(int numRow, int numCol)  
{
    double[,] tmpArray = new double[numRow, numCol];
    Random tmpRand = new Random();

    for (int r = 0; r < numRow; r++) {
        for (int c = 0; c < numCol; c++) {
            tmpArray[r, c] = Math.Round(tmpRand.NextDouble()*10, 1);
        }
    }
    return(tmpArray);
}

//Создание двумерного массива типа int
int[,] CreateArrayIntTwoDim(int numRow, int numCol)  
{
    int[,] tmpArray = new int[numRow, numCol];
    Random tmpRand = new Random();

    for (int r = 0; r < numRow; r++) {
        for (int c = 0; c < numCol; c++) tmpArray[r, c] = tmpRand.Next(0, 9);
    }
    return(tmpArray);
}

bool PozArrayTwoDim(int row, int col, double[,] array)
{
    if (row <= array.GetLength(0) && col <= array.GetLength(1)) return true;
    return false;
}

Console.WriteLine("Урок 7 - работа с двумерным массивом\n");
Console.Write("Задача 47. Создание двумерного массива\n");
    
Console.Write("Задайте количество строк\t> ");
int taskRow = Convert.ToInt32(Console.ReadLine());
    
Console.Write("Задайте количество столбцов\t> ");
int taskCol = Convert.ToInt32(Console.ReadLine());

double[,] tmpArray = CreateArrayDoubleTwoDim(taskRow, taskCol);

Console.Write("Вывeсти на экран? y/n > ");
string? taskCharPrint = Console.ReadLine();

if (taskCharPrint == "y") {       // вывод массива на печать
    for (int r = 0; r < taskRow; r++) {
        for (int c = 0; c < taskCol; c++) Console.Write($"{tmpArray[r, c]}\t");
        Console.WriteLine();
    }
}   

Console.Write("Задача 50. Есть ли в массиве позиция с такими индексами\n");
Console.Write("Максимальная величина элемента массива 9 для красоты вывода\n");
    
Console.Write("Задайте номер строки\t> ");
int tmpRow = Convert.ToInt32(Console.ReadLine());
    
Console.Write("Задайте номер столбца\t> ");
int tmpCol = Convert.ToInt32(Console.ReadLine());

bool poz = PozArrayTwoDim(tmpRow, tmpCol, tmpArray);

if (poz == true) Console.WriteLine("Элемент с такими индексами в массиве есть");
else Console.WriteLine("Элемента с такими индексами в массиве нет");
  


    
