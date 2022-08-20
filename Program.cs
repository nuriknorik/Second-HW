/*Реализуйте класс дробь и перегрузите математические операторы а также перегрузите ToString().
    Подсказка - Не забудьте про Equals()*/


namespace Program
{
    class Program
    {
        public static Fraction solution(char solution,Fraction first, Fraction second) => solution switch
        {
            '*' => first *= second,
            '/' => first /= second,
            '+' => first += second,
            '-' => first-= second
        };

        public static void Main()
        {
            Console.Write("Enter first numerator: ");
            Int32 dividend1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter first denominator: ");
            Int32 divider1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter second numerator  : ");
            Int32 dividend2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter second denominator: ");
            Int32 divider2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Pleace enter  * / + -  ");
            Char select = Convert.ToChar(Console.Read());

            Fraction second;
            Fraction first = null;
            Console.WriteLine(first);

        }
    }
}
class Fraction
    {
        private readonly int _numerator;
        private int _denominator;
        public Fraction() { }
        public Fraction(Int32 numerator , Int32 denominator)
        {
            this._numerator = numerator * (denominator >= 0 ? 1 : -1);
            this._denominator = denominator * (denominator >= 0 ? 1 : -1);
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            if (first._denominator == second._denominator) return new Fraction(first._numerator + second._denominator, first._denominator);
            else if (first._denominator % second._denominator == 0 || second._denominator % first._denominator == 0)
            {
                return new Fraction(first._numerator* (second._denominator / first._denominator == 0 ? 1 : second._denominator / first._denominator) +
                                    second._numerator * (first._denominator / second._denominator== 0 ? 1 : first._denominator / second._denominator), (first._denominator > second._denominator ? first._denominator : second._denominator));
            }
            return new Fraction(first._numerator * second._denominator + second._numerator * first._denominator, first._denominator * second._denominator);
        }
        public static Fraction operator -(Fraction first, Fraction second)
        {
            if (first._denominator == second._denominator) return new Fraction(first._numerator - second._numerator, first._denominator);
            else if (first._denominator % second._denominator== 0 || second._denominator% first._denominator == 0)
            {
                return new Fraction(first._numerator * (second._denominator / first._denominator== 0 ? 1 : second._denominator / first._denominator) -
                                    second._numerator * (first._denominator/ second._denominator == 0 ? 1 : first._denominator / second._denominator), (first._denominator > second._denominator ? first._denominator : second._denominator));
            }
            return new Fraction(first._numerator * second._denominator - second._numerator * first._denominator, first._denominator * second._denominator);
        }
        public static Fraction operator *(Fraction first, Fraction second) => new Fraction(first._numerator * second._numerator , first._denominator * second._denominator);
        public static Fraction operator /(Fraction first, Fraction second) => new Fraction(first._numerator * second._denominator , first._denominator * second._denominator);

        public static bool operator >(Fraction first, Fraction second) =>
            (first._numerator / first._denominator > second._numerator / second._denominator);

        public static bool operator <(Fraction first, Fraction second) =>
            (first._numerator / first._denominator < second._numerator / second._denominator);

        public static bool operator ==(Fraction first, Fraction second) =>
            (first._numerator / first._denominator == second._numerator / second._denominator);

        public static bool operator !=(Fraction first, Fraction second) =>
            (first._numerator / first._denominator != second._numerator / second._denominator);
        
        private Int32 Dividend { get; } 
        private Int32 Divider { get; }

    }