// Написать программу, которая из имеющегося массива строк формирует массив из строк, дли которых меньше либо равна 3 символа.

(string[], int) EnterTheStrings(int size)
{
    string[] startArray = new string[size];
    int counter = 0;

    Console.WriteLine("Enter the strings (<end> to finish):");
    while (counter < size)
    {
        startArray[counter] = Console.ReadLine();
        if (startArray[counter] != "end") counter++;
        else break;
    }

    return (startArray,counter);
}

string[] CheckArray(string[] startArray, int counter)
{
    string[] finalArray = new string[counter];

    for (int i = 0, j = 0; i < counter; i++)
        if (startArray[i].Length <= 3) finalArray[j++] = startArray[i];

    return finalArray;
}



int size = 10;
(string[] startArray, int counter) = EnterTheStrings(size);
System.Console.WriteLine(String.Join(' ', startArray));

string[] finalArray = CheckArray(startArray, counter);
System.Console.WriteLine(String.Join(' ', finalArray));