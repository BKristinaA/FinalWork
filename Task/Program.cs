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
