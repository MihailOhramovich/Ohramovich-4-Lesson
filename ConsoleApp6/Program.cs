using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        /// <summary>
        /// Класс для работы с дробятми
        /// </summary>
        class Fraction
        {

            /// <summary>
            /// Числитель (рациональное число)
            /// </summary>
            private int _numerator;

            /// <summary>
            /// Знаменатель (натуральное число)
            /// </summary>
            private int _denominator;

            /// <summary>
            /// Числитель
            /// </summary>
            public int Numerator
            {
                get { return _numerator; }
                set { value = _numerator; }
            }

            /// <summary>
            /// Знаменатель
            /// </summary>
            public int Denominator
            {
                get { return _denominator; }
                set
                {
                    if (value == 0)
                        throw new ArgumentException("Знаменатель не может быть равен 0");
                    value = _denominator;
                }
            }

            /// <summary>
            /// Получить десятичную дробь
            /// </summary>
            public double GetFraction
            {
                get { return (double)_numerator / _denominator; }
            }

            /// <summary>
            /// Инициализация дроби
            /// </summary>
            /// <param name="numerator">Числитель</param>
            /// <param name="denominator">Знаменатель</param>
            public Fraction(int numerator, int denominator)
            {
                if (denominator <= 0)
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                _numerator = numerator;
                _denominator = denominator;
                // Автоматическая нормализация дроби (при необходимости)
                Nod();
            }

            /// <summary>
            /// Сложение дробей
            /// </summary>
            /// <param name="f">Дробь</param>
            /// <returns>Результат сложения дробей</returns>
            public Fraction Plus(Fraction f)
            {
                var den = _denominator * f.Denominator;
                var num = _numerator * f.Denominator + f.Numerator * Denominator;
                return new Fraction(num, den);
            }

            /// <summary>
            /// Вычитание дробей
            /// </summary>
            /// <param name="f">Дробь</param>
            /// <returns>Результат вычитания дробей</returns>
            public Fraction Minus(Fraction f)
            {
                var den = _denominator * f.Denominator;
                var num = _numerator * f.Denominator - f.Numerator * Denominator;
                return new Fraction(num, den);
            }

            /// <summary>
            /// Произведение дробей
            /// </summary>
            /// <param name="f">Дробь</param>
            /// <returns>Результат произведения дробей</returns>
            public Fraction Multi(Fraction f)
            {
                var den = _denominator * f.Denominator;
                var num = _numerator * f.Numerator;
                return new Fraction(num, den);
            }

            /// <summary>
            /// Нормальизация дроби
            /// </summary>
            private void Nod()
            {
                var num = Math.Abs(_numerator);
                var den = Math.Abs(_denominator);
                int temp;

                while (num != 0 && den != 0)
                {
                    if (num % den > 0)
                    {
                        temp = num;
                        num = den;
                        den = temp % den;
                    }
                    else
                        break;
                }

                if (num != 0 && den != 0)
                {
                    _numerator = _numerator / den;
                    _denominator = _denominator / den;
                }
            }

            public override string ToString()
            {
                Nod();
                return $"{_numerator}/{_denominator}";
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
