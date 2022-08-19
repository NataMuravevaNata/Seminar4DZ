// Написать программу масштабирования фигуры

Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите x3");
int x3 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите y3");
int y3 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите x4");
int x4 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите y4");
int y4 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Вершины фигуры:");
Console.WriteLine($"{(x1,y1)} {(x2,y2)} {(x3,y3)} {(x4,y4)}");
int k=4;
Console.WriteLine($"{(k*x1,k*y1)} {(k*x2,k*y2)} {(k*x3,k*y3)} {(k*x4,k*y4)}");