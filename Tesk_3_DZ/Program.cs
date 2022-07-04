// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце 
 
 
int [,] CreateArray ()             // Создание массива  
{ 
    Console.WriteLine("Введите кол-во строк:  "); 
    int m = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите кол-во строк:  "); 
    int n = Convert.ToInt32(Console.ReadLine()); 
     
    int [,] array = new int [m,n]; 
    return array; 
}  
 
void FillArray (int [,] array)     // Заполнение массива  
{ 
    for (int i = 0; i < array.GetLength(0); i++) // Переменная i идет по строкам  
    { 
        for (int j = 0; j < array.GetLength(1); j++)   // Переменная j идет по столбцам 
        { 
            array[i,j] = new Random().Next(1,10); 
             
        } 
    } 
} 
 
void PrintArray (int [,] array)    // Вывод массива 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i,j]}  "); 
        } 
        Console.WriteLine(); 
    } 
} 
 
 
void Arithmetic (int [,] array)    //  Среднее арифметическое элементов
{ 
    for (int j = 0; j < array.GetLength(1); j++)    
        { 
            double Sum = 0; 
            double arithmetic = 0; 
            for (int i = 0; i < array.GetLength(0); i++) 
            { 
                Sum = Sum + array[i,j]; 
            } 
            arithmetic = Math.Round((Sum / array.GetLength(0)), 1); 
            Console.WriteLine(arithmetic); 
        } 
    Console.WriteLine(); 
} 
 
 
 
int [,] arr = CreateArray(); 
FillArray(arr); 
PrintArray(arr); 
Console.WriteLine();
Arithmetic(arr);
