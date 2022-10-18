// Программа запрашивает у пользователя пройденное расстояние,
// а также израсходованный объем топлива. Далее выводит средний расход топлива.

Console.Write("Введите пройденное расстояние в километрах: ");
double a = Double.Parse(Console.ReadLine());
if (a == 0) Console.WriteLine("На парковке топливо не расходуется.");
else
{
    Console.Write("Введите расход топлива в литрах: ");
    double b = Double.Parse(Console.ReadLine());
    double x = Math.Round((b / a) * 100, 0);
    Console.Write($"Расход топлива {x} литров на 100 км.");
}
Console.ReadKey();