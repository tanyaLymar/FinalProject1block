/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина
 которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на 
 старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
 исключительно массивами.*/

string [] array = new string [8] {"hello", "2", "world", ":-)","1234", "1567", "-2", "computer science", };
string [] newArray = new string [array.Length];

void FillNewArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            {
            newArray[count] = array[i];
            count++;
            }
    }
}

void PrintArray(string[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillNewArray(array, newArray);
PrintArray(newArray);
