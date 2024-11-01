Console.WriteLine("Enter the value of a: "); double.TryParse(Console.ReadLine(), out double a);
Console.WriteLine("Enter the value of b: "); double.TryParse(Console.ReadLine(), out double b);
Console.WriteLine("Enter the value of c: "); double.TryParse(Console.ReadLine(), out double c);
Console.WriteLine("Enter the value of d: "); double.TryParse(Console.ReadLine(), out double d);

double x, y, z, r;
x = ((a + 2*b - c + d) / (c*d)) + ((a + b)/(c - d)) - (Math.Pow(a, 2)/Math.Pow(b, 2));
y = 5 * (a + b) * (c - d) / ((1 / 2) * c) + double.Pow(b, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b-a));
z = (Math.Pow(x*x - 2*x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5*a + 3*b);
r = (1/2 * a + 3/4 * b + 7/5) / (3*c + 1) + 1 / (a - c);
Console.WriteLine($"x = {x}, y = {y}, z = {z}, r = {r}");
