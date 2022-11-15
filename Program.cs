 // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
 //которая покажет количество чётных чисел в массиве.
//int[] GenerateRandomArray(int size, int start, int maxval)
//{
//int[] RandomArray = new int[size];
//for (int i = 0; i < size; i++)
//  {
//RandomArray[i] = new Random().Next(start, maxval + 1);
//  }
//
//return RandomArray;
//}

//void ShowArray(int[] Array1)
//{
//for (int i = 0; i < Array1.Length; i++)
//  {
//  Console.Write(Array1[i] + " ");
//  }
  ////Console.Write();
//}

//int CheckOfEven(int[] myArray2)
//{
//int Count = 0;
//for (int i = 0; i < myArray2.Length; i++)
//if (myArray2[i] % 2 == 0)
//{
//Count = Count + 1;
//}
//return Count; 
//}
//int[] myArray = new int[4];
//myArray = GenerateRandomArray(4, 100, 999);
//ShowArray(myArray);
 //Console.WriteLine("The numbers we are looking for  " + CheckOfEven(myArray));

//Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
//Console.WriteLine(" Input the size of the array  ");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[size];
//MyRandomArray(numbers);
//Console.WriteLine("Array: ");
//PrintArray(numbers);
// int sum = 0;
//    for(int i = 0; i < numbers.Length; i++) {
//        if(i % 2 != 0) 
//        {
//            sum = sum + numbers[i];
//        }
//    }
//    Console.WriteLine($" {numbers.Length} the sum we are lookng for  = {sum}");

//void MyRandomArray(int[] numbers)
//{
//    for(int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = new Random().Next(-10,99);
//        }
//}
//void PrintArray(int[] numbers)
//{
//    for(int i = 0; i < numbers.Length; i++)
//        {
//            Console.Write(numbers[i] + " ");
//        }
//    
//    Console.WriteLine();
//}
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.0 7.2 22.7 2.1 78.3] -> 76.2
//double RealNumber(double [] arr)
//{
//    double min = arr[0];
//    double max = arr [0]; 
//    for ( int i = 0; i < arr.Length; i++)
//        {
//            if (arr [0] <= min)
//            {
//            min = arr[i];
//            }
//            if(arr [i] >= max) 
//            {
//                max = arr[i];
//            };
//        }
//        return (max-min);
//}
//double [] arr = {3.0,7.2,22.7,2.1,78.3};
//Console.Write($"Our difference is  = {RealNumber(arr)}"); 




