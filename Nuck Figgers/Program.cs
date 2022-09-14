// Коваленко Артём 22-ИСП-2/2 вариант 13

try
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите y:");
    double y = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Green;
    double res = (((Math.Cos(x)) / (Math.PI - 2 * x)) + 16 * x * Math.Cos(x * y) - 2);
    Console.WriteLine($"{res:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString()); 
}