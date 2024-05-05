// Урок 1. Контрольная работа
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] array) // Имеющийся массив строк
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"“{array[i]}”, ");
        }
        else
        {
            Console.Write($"“{array[i]}”");
        }
    }
    Console.WriteLine("]");
}


﻿int LineThreeSignsMax(string[] array) // Строка из 3х или менее символов, l - length (длина строк)
{
    int l = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            l++;
        }
    }
    return l;
}

string[] CreateNewArray(string[] array) // Формируем новый массив из строк, длина которых меньше, либо равна 3 символам. 
{
    int k = 0;
    string[] newArray = new string[LineThreeSignsMax(array)];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
}



// Console.WriteLine(LineThreeSignsMax(arr));

string[] array0 = { "Hello", "2", "world", ":-)" };
string[] array1 = { "1234", "1567", "-2", "computer science" };
string[] array2 = { "Russia", "Denmark", "Kazan" };

string[] arrNew0 = CreateNewArray(array0);
PrintArray(arrNew0);
string[] arrNew1 = CreateNewArray(array1);
PrintArray(arrNew1);
string[] arrNew2 = CreateNewArray(array2);
PrintArray(arrNew2);

