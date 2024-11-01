Console.WriteLine("Enter the value of m: "); double.TryParse(Console.ReadLine(), out double m);
Console.WriteLine("Enter the value of n: "); double.TryParse(Console.ReadLine(), out double n);

double z1, z2, y;
z1 = ((m - 1) * Math.Log(m) - (n - 1) * Math.Log(n)) / (Math.Log(Math.Pow(m, 3) * n) + n*m + m*m - m);
z2 = (Math.Log(m) - Math.Log(n)) / m;
Console.WriteLine($"The value of z1: {z1}, z2: {z2}");

Console.WriteLine("Enter the value of a: "); double.TryParse(Console.ReadLine(), out double a);
Console.WriteLine("Enter the value of b: "); double.TryParse(Console.ReadLine(), out double b);
Console.WriteLine("Enter the value of x: "); double.TryParse(Console.ReadLine(), out double x);

y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine($"The value of y: {y}");