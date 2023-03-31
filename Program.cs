// напишите программу которая из имеющегося массива строк формирует 
//массив из строк длина которых меньше либо равна 3 символа.
//Первоначальный массив можно ввести с клавиатуры,либо задать на старте алгоритма.
//При решении не рекомендуется пользоваться коллекциями,лучше обойтись исключительно массивами.
//Создать репозиторий на github
//Нарисовать блок схему
//Создать ReadMe.md
//Написать программу и создать несколько коммитов.


string[] arrayStart = new string[8] {"Hello", "world", "!", "Peace", "Hi", "Polina", "And", ":)"};
string[] arrayFinal = new string[arrayStart.Length];
void ShortArray(string[] arrayStart, string[] arrayFinal)

{
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
    if(arrayStart[i].Length <= 3)
        {
        arrayFinal[count] = arrayStart[i];
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
ShortArray(arrayStart, arrayFinal);
PrintArray(arrayFinal);
