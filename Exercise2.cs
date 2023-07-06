// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int ReadInt(string message)
{
    System.Console.Write(message);              
    return Convert.ToInt32(Console.ReadLine()); 
}
int x1 = ReadInt("Введите x1 =>");
int y1 = ReadInt("Введите y1 =>");
int z1 = ReadInt("Введите z1 =>");
int x2 = ReadInt("Введите x2 =>");
int y2 = ReadInt("Введите y2 =>");
int z2 = ReadInt("Введите z2 =>");
int rangeX = x1 - x2;
int rangeY = y1 - y2;
int rangeZ = z1 - z2;
double range = Math.Sqrt(rangeX*rangeX + rangeY*rangeY + rangeZ*rangeZ);
System.Console.WriteLine("Расстояние между координатами равно " + range);
