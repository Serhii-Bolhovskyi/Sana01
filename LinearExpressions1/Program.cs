Console.WriteLine("Enter the value of a: "); double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of b: "); double b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of c: "); double c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the value of d: "); double d = double.Parse(Console.ReadLine());

double x, y, z, r;
x = ((a + 2*b - c + d) / (c*d)) + ((a + b)/(c - d)) - (Math.Pow(a, 2)/Math.Pow(b, 2));
y = 5 * (a + b) * (c - d) / ((1 / 2) * c) + double.Pow(b, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b-a));
z = (Math.Pow(x*x - 2*x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5*a + 3*b);
r = (1/2 * a + 3/4 * b + 7/5) / (3*c + 1) + 1 / (a - c);
Console.WriteLine("x = {0}, y = {1}, z = {2}, r = {3}", x, y, z, r);
