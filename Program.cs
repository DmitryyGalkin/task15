Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number == 6 ^ number == 7)
    Console.WriteLine("Да - это выходной день");
else if (number < 1 ^ number > 7)
    Console.WriteLine("Такого дня недели нет");
else
    Console.WriteLine("Нет - это не выходной день");

