/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. */

string[] array1 = new string[] { "8", "800", "555", "hello", "world", "3535" };
int maxLengthOfTheArrayElement = 3;
if (LengthOfTheSecondArray(array1) == 0) { Console.WriteLine("There are no elements less than four characters in the array"); }
else
{
    string[] array2 = Array2Formation(array1);
    Console.WriteLine($"[{String.Join(", ", array1)}] -> [{String.Join(", ", array2)}]");
}
int LengthOfTheSecondArray(string[] array1)
{
    int lengthOfArray2 = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= maxLengthOfTheArrayElement)
        {
            lengthOfArray2++;
        }
    }
    return lengthOfArray2;
}
string[] Array2Formation(string[] array1)
{
    string[] array2 = new string[LengthOfTheSecondArray(array1)];
    for (int i = 0, j = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= maxLengthOfTheArrayElement)
        {
            array2[j] = array1[i];
            j++;
        }
    }
    return array2;
}