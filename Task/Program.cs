// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символам.

string[] array = {"hello", "2", "world", ":-)"}; 
string[] resultArray = new string[array.Length];

FillArray(array);
Console.WriteLine();
Print(resultArray);

void FillArray (string[] array)
{
     int index = 0;
     for (int i=0; i < array.Length; i++)
     {      
        if(array[i].Length <= 3)
        {
        resultArray[index] = array[i];
        index++;
        }
     } 
}

void Print(string[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}