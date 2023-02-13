string[] FillArray()
{
  Console.Write("\nВведите текст через пробел: ");
  return Console.ReadLine()!.Split(" ");
}