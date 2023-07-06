// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int ReadInt(string message)
{
    System.Console.Write(message);              // Подсказка
    return Convert.ToInt32(Console.ReadLine()); // Преобразование введенной пользователем строки в число
}
int N = ReadInt("Введите число => ");
int count = 1;
while (count <= N)
{
    System.Console.WriteLine(count*count);
    count++;
}