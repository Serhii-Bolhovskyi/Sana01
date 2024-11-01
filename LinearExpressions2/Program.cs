Console.WriteLine("Enter the value of m: "); double.TryParse(Console.ReadLine(), out double m);
Console.WriteLine("Enter the value of n: "); double.TryParse(Console.ReadLine(), out double n);

double z1, z2;
z1 = ((m - 1) * Math.Log(m) - (n - 1) * Math.Log(n)) / (Math.Log(Math.Pow(m, 3) * n) + n*m + m*m - m);
z2 = (Math.Log(m) - Math.Log(n)) / m;
Console.WriteLine($"The value of z1: {z1}, z2: {z2}");