Console.WriteLine("Введите целое число А");
int number_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число B");
int number_B = Convert.ToInt32(Console.ReadLine());

if(number_A / number_B == number_B)
{
    Console.WriteLine($"Число {number_A}  - квадрат числа {number_B}");
}
else
{
    Console.WriteLine($"Число {number_A} не является квадратом числа {number_B}");
}