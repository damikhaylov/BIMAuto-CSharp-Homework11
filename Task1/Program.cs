using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Разработать структуру для решения линейного уравнения 0 = kx + b.Коэффициенты уравнения
            k, b реализовать с помощью полей вещественного типа. Для решения уравнения 
            предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить 
            использование экземпляра в программе.
            */
            Console.WriteLine("Извлечение корня линейного уравнения\n");
            Console.WriteLine("Введите коэффициенты линейного уравнения 0 = kx + b");
            try
            {
                LinearEquation linEq;
                Console.Write("k = ");
                linEq.k = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                linEq.b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Корень уравнения x = {0}", linEq.Root());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }
            Console.ReadKey();
        }
    }
    struct LinearEquation
    {
        public double k;
        public double b;
        public double Root()
        {
            if (k != 0)
            {
                return -b / k;
            }
            else
            {
                throw new Exception("При коэффициентк k = 0 уравнение не имеет решения.");
            }
        }
    }
}
