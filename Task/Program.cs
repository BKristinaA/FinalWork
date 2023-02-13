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

