//
//
//
Console.Write("Введите число: ");
int number = int.Parse(s: Console.ReadLine());
int str = number * number;

// Вывод построчно
Console.Write("Квадрат числа ");
Console.Write(number);
Console.Write(" равен = ");
Console.Write(str);
Console.WriteLine();

// Вывод с использованием $
Console.WriteLine($"Квадрат числа {number} равен = {str}");

// Вывод с обращением к перенменным
Console.WriteLine("Квадрат числа {0} равен = {1}", number, str);

//использование библиотеки Math
int sqr = Convert.ToInt32(Console.ReadLine());
double sqr_2 = Math.Pow(sqr,2);
Console.WriteLine("Квадрат числа {0} равен = {1}", sqr, sqr_2);

