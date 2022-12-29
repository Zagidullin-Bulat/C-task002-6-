// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Не использовать массив.

Console.WriteLine("Введите колличество элементов: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int numbers=0; M>numbers; numbers++)
    {
        Console.WriteLine ("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            count++;
        }
    }

Console.WriteLine($"Кол-во элементов {M}, больше 0 равно {count}");