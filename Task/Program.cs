string[] FillArray()
{
  Console.Write("\nВведите текст через пробел: ");
  return Console.ReadLine()!.Split(" ");
}

int CountElementInStringArray(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int CountElemetNewArray(string[] collection, int countSymbol) 
{
    int count = 0;
    for(int i = 0; i < collection.Length; i++) 
    {
        if(collection[i].Length <= countSymbol) 
        {
            count++;
        }
    }
    return count;
}

string[] GetNewArrayString(string[] collection, int lengthArray, int countSymbol)
{   
    string[] newArr = new string[lengthArray];
    int newIndex = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i].Length <= countSymbol)
        {
            newArr[newIndex] = collection[i];
            newIndex++;
        }
        
    }
    return newArr;
}

string PrintArray(string[] priarray)
{
    string output = String.Empty;
    for (int i = 0; i < priarray.Length; i++)
    {
        output = output + $"{priarray[i]} ";
    }
    return output;
}
string[] arr = FillArray();
int countSymbol = CountElementInStringArray("\nВедите количество символовов для элементов нового массива (по условию задачи <= 3): ");
string[] newArr = GetNewArrayString(arr, CountElemetNewArray(arr, countSymbol), countSymbol);
string print = PrintArray(arr);
string newPrint = PrintArray(newArr);
Console.WriteLine($"\nИзначальный массив строк [ {print}] => \nОтформатированный массив строк [ {newPrint}]\n");