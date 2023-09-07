using System;
class Program
{
    public static void Main(string[] args) 
    {
        {//Задание 1. Вывод трёх строк
            Console.WriteLine("{0, 50}", "Задание 1. Вывод трёх строк");
            string str1 = "Мир", str2 = "Труд", str3 = "Май";
            Console.WriteLine(str1 + " " + str2 + " " + str3);//пункт а
            Console.WriteLine(str1);
            Console.WriteLine("{0, 6}", str2);
            Console.WriteLine("{0, 8}", str3);//пункт b
        }
        {//Задание 3. Нахождение площади круга и длины окружности по введенному пользователем углу
            Console.WriteLine("{0, 50}", "Задание 3. Нахождение площади круга и длины окружности по введенному пользователем углу");
            Console.Write("Введите радиус окружности: ");
            double r = Convert.ToInt32(Console.ReadLine());
            double l = 2 * Math.PI * r;//длина окружности
            double s = Math.PI * r * r;//площадь круга
            Console.WriteLine("Длина окружности: {0}; площадь круга: {1}", l, s);
        }
        {//Задание 4. Найти у = cos(x)
            Console.WriteLine("{0, 50}", "Задание 4. Найти у = cos(x)");
            Console.Write("Введите угол в градусах: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos((x / 180)*Math.PI);//нахождение cos(x) + перевод х в радианы
            Console.WriteLine($"Cos = {y}");
        }
        {//Задание 5. Найти корни квадратного уравнения. a, b, c вводит пользователь
            Console.WriteLine("{0, 50}", "Задание 5.Найти корни квадратного уравнения.a, b, c вводит пользователь");
            Console.Write("Введите коэффициент а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            double discr = (b * b) - (4 * a * c);//дискриминант
            double sqrt_discr = Math.Sqrt((b * b) - (4 * a * c));//корень из дискриминанта
            double x1 = 0;
            double x2 = 0;
            if (discr < 0)
            {
                Console.WriteLine("Уравнение не имеет корней");
            }
            if (discr == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine($"Уравнение имеет 1 корень:{x1}");
            }
            if (discr > 0)
            {
                x1 = ((-b) + sqrt_discr) / (2 * a);
                x2 = ((-b) - sqrt_discr) / (2 * a);
                Console.WriteLine($"Уравение имеет два корня: {x1} и {x2}");
            }
        }
        {//Задание 7. Вывод четырех случайных чисел столбиком
            Console.WriteLine("{0, 50}", "Задание 7. Вывод четырех случайных чисел столбиком");
            Random rnd = new Random();//создание экземпляра класса Random
            int r1 = rnd.Next();//Next - метод, возвращающий случайное неотрицательное число
            int r2 = rnd.Next();
            int r3 = rnd.Next();
            int r4 = rnd.Next();
            Console.Write("Вывод 4 случайных чисел столбиком: ");
            Console.WriteLine($"\n{r1}\n{r2}\n{r3}\n{r4}");
        }
        {/*Задание 9. Известна стоимость 1 кг конфет, 1 кг печенья и 1 кг яблок. Найти стоимость всей
            покупки, если купили x кг конфет, у кг печенья и z кг яблок.*/
            Console.WriteLine("{0, 50}", "Задание 9. Найти сумму покупки X кг конфет, Y кг печенья и Z кг яблок. Все данные вносит пользователь");
            Console.Write("Введите стоимость 1 кг конфет: ");
            double price_candies = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг печенья: ");
            double price_cookies = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг яблок: ");
            double price_apples = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество купленных килограмм конфет: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество купленных килограмм яблок: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество купленных килограмм печенья: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double sum = x*price_candies + y*price_cookies + z*price_apples;
            Console.WriteLine("Сумма покупки: {0}", sum);
            Console.ReadKey();
        }
    }
}