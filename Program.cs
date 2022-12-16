// Решение в группах задач: 
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. 
// [-4, -8, 8, 2] -> [4, 8, -8, -2]  
 
 
 
int[] GetArray(int size, int leftRange, int RightRange) 
{ 
    int[] arr = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        arr[i] = new Random().Next(leftRange, RightRange + 1); 
    } 
    foreach (var item in arr) 
    { 
        System.Console.Write(item + " "); 
    } 
    return arr; 
} 
int[] myArray = GetArray(10, -9, 9); 
System.Console.WriteLine(); 
void ReverseArray(int[] arr) 
{ 
    for (int i = 0; i < arr.Length; i++) 
    { 
        arr[i] = arr[i] * -1; 
    } 
    foreach (var item in arr) 
    { 
        System.Console.Write(item + " "); 
    } 
} 
ReverseArray(myArray);


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет 
// 3; массив [6, 7, 19, 345, 3] -> да 
 
 
Console.Clear(); 
const int SIZE = 20; 
const int LEFT_RANGE = -10; 
const int RIGHT_RANGE = 10; 
int num = inputNumber(); 
int[] myArray = GetArray(SIZE, LEFT_RANGE, RIGHT_RANGE); 
System.Console.WriteLine(); 
System.Console.WriteLine(NumberInArray(myArray, num)); 
 
 
 
 
 
 
int[] GetArray(int SIZE, int LEFT_RANGE, int RIGHT_RANGE) 
{ 
    int[] arr = new int[SIZE]; 
    for (int i = 0; i < SIZE; i++) 
    { 
        arr[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE + 1); 
    } 
    foreach (var item in arr) 
    { 
        System.Console.Write(item + " "); 
    } 
    return arr; 
} 
 
 
string NumberInArray(int[] arr, int num) 
{ 
    for (int i = 0; i < arr.Length; i++) 
    { 
        if (arr[i] == num) 
            return "да, массив содержит введенное число!"; 
    } 
    return "нет, в массиве нету введенного числа!"; 
} 
 
int inputNumber() 
{ 
    int number; 
    string text; 
 
    while (true) 
    { 
        Console.Write("Введите число: "); 
        text = Console.ReadLine(); 
        if (int.TryParse(text, out number)) 
        { 
            break; 
        } 
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); 
    } 
    return number; 
}


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].  
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123 
// [5, 18, 123, 6, 2] -> 1 
// [1, 2, 3, 6, 2] -> 0 
// [10, 11, 12, 13, 14] -> 5 
 
 
Console.Clear(); 
const int SIZE = 30; 
const int LEFT_RANGE = -100; 
const int RIGHT_RANGE = 100; 
int[] myArray = GetArray(SIZE, LEFT_RANGE, RIGHT_RANGE); 
System.Console.WriteLine(); 
System.Console.WriteLine(FindNumber(myArray)); 
 
 
 
int[] GetArray(int SIZE, int LEFT_RANGE, int RIGHT_RANGE) 
{ 
    int[] arr = new int[SIZE]; 
    for (int i = 0; i < SIZE; i++) 
    { 
        arr[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE + 1); 
    } 
    foreach (var item in arr) 
    { 
        System.Console.Write(item + " "); 
    } 
    return arr; 
} 
 
string FindNumber(int[] arr) 
{ 
    int count = 0; 
    foreach (var item in arr) 
    { 
        if (item > 10 && item < 100) 
            count += 1; 
    } 
    return $"Количество чисел больше 10 и меньше 100:   {count}"; 
}


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21 
 
 
Console.Clear(); 
const int SIZE = 9; 
const int LEFT_RANGE = -5; 
const int RIGHT_RANGE = 5; 
int[] myArray = GetArray(SIZE, LEFT_RANGE, RIGHT_RANGE); 
System.Console.WriteLine(); 
printArray(GetSum(myArray)); 
 
 
 
 
 
 
 
 
 
int[] GetArray(int SIZE, int LEFT_RANGE, int RIGHT_RANGE) 
{ 
    int[] arr = new int[SIZE]; 
    for (int i = 0; i < SIZE; i++) 
    { 
        arr[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE + 1); 
    } 
    foreach (var item in arr) 
    { 
        System.Console.Write(item + " "); 
    } 
    return arr; 
} 
 
 
int[] GetSum(int[] arr) 
{ 
    int[] myArray = new int[(arr.Length / 2) + (arr.Length % 2)]; 
    for (int i = 0; i < arr.Length / 2; i++) 
    { 
        myArray[i] = arr[i] * arr[(arr.Length - 1) - i]; 
    } 
    if (arr.Length % 2 != 0) 
        myArray[myArray.Length - 1] = arr[arr.Length / 2]; 
    return myArray; 
} 
 
void printArray(int[] arr) 
{ 
    System.Console.WriteLine($"[{String.Join(", ", arr)}]"); 
}

