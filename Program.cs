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

    Console.WriteLine($"Массив из {numRow} строк и  {numCol} столбцов создан > ");

    for (int r = 0; r < numRow; r++) {
        for (int c = 0; c < numCol; c++) {
            tmpArray[r, c] = Math.Round(tmpRand.NextDouble()*10, 1);
            Console.Write($"{tmpArray[r, c]}\t");
        }
        Console.WriteLine();
    }
    return(tmpArray);
}


CreateArrayDoubleTwoDim(7, 5);