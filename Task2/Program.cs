string[] colors = new string[] { "red", "blue", "green", "gray", "black" };
for (int i = 0; i < colors.Length; i++)
    Console.Write(colors[i] + " ");
Console.ReadKey();
Console.WriteLine();

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

string[] RemoveOdd(string[] colors)
{
    int count = 0;
    string[] resultArr = new string[count];
    for (int i = 0; i < colors.Length; i++)
    {
        if (colors[i].Length <= 3)
        {
            Array.Resize(ref resultArr, resultArr.Length + 1);
            resultArr[resultArr.Length - 1] = colors[i];
        }

    }
    return resultArr;
}








