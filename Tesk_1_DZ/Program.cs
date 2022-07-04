// Задайте двумерный массив размером m x n,
// заполненный случайными вещевственными числами. 
// m = 3, n = 4.
// 0,5 7  -2 -0,2
// 1 -3, 3 8 -9,9
// 8 7, 8 -7, 1 9

double   [,] CreateArray ()                            // Создание массива  
{ 
    Console.WriteLine("Введите кол-во строк:  "); 
    int m = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите кол-во столбцов:  "); 
    int n = Convert.ToInt32(Console.ReadLine()); 
     
    double [,] array = new double [m,n]; 
    return array; 
}  
 
void FillArray (double [,] array)                      // Заполнение массива  
{ 
    for (int i = 0; i < array.GetLength(0); i++)       // Переменная i идет по строкам  
    { 
        for (int j = 0; j < array.GetLength(1); j++)   // Переменная j идет по столбцам 
        { 
            array[i,j] = Math.Round(((new Random().NextDouble())*20-10),1); 
             
        } 
    } 
} 
 
void PrintArray (double [,] array)                      // Вывод массива 
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

double [,] Array = CreateArray ();
FillArray (Array);
PrintArray (Array);