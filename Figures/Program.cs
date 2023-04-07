
using System.Security.Cryptography.X509Certificates;

class Figure 
{
    public Figure() { }
    public virtual double perimeter()
    {
        int res = 1;   
        return res;
    }

    public virtual double area()
    {
        int res = 1;
        return res;
    }
} 

// Трикутник
class Triangle : Figure
{
    int a;
    int b;
    int c;
    public Triangle(int a, int b, int c) 
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Одна із змінних менша/дорівнює нулю");
            return;
        }
        else if (a + b <= c || c + b <= a || a + c <= b)
        {
            Console.WriteLine("З такими зміними трикутник не може існувати");
        }
        else 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    public override double perimeter()
    {
        return a + b + c;
    }

    public override double area()
    {
        float p = (a + b + c) / 2;
        return Math.Sqrt(p*(p - a) * (p - b) * (p - c));
    }
}

// Квадрат
class Square : Figure
{
    int a;
    public Square(int a)
    {
        if (a <= 0)
        {
            Console.WriteLine("Одна із змінних менша/дорівнює нулю");
            return;
        }
        else
        {
            this.a = a;
        }
    }

    public override double perimeter()
    {
        return a*4;
    }

    public override double area()
    {
        return a*a;
    }
}

//Прямокутник
class Rectangle : Figure
{
    int a;
    int b;
    public Rectangle(int a, int b)
    {
        if (a <= 0 || b <= 0)
        {
            Console.WriteLine("Одна із змінних менша/дорівнює нулю");
            return;
        }
        else
        {
            this.a = a;
            this.b = b;
        }
    }

    public override double perimeter()
    {
        return (a + b) * 2;
    }

    public override double area()
    {
        return a * b;
    }
}

class Romb : Figure
{
    int a;
    int h;
    public Romb(int a, int h)
    {
        if (a <= 0 || h <= 0)
        {
            Console.WriteLine("Одна із змінних менша/дорівнює нулю");
            return;
        }
        else
        {
            this.a = a;
            this.h = h;
        }
    }

    public override double perimeter()
    {
        return a * 4;
    }

    public override double area()
    {
        return a * h;
    }
}

class Parallelogram : Figure
{
    int a;
    int b;
    int h_a;
    public Parallelogram(int a, int b, int h_a)
    {
        if (a <= 0 || h_a <= 0 || b <= 0)
        {
            Console.WriteLine("Одна із змінних менша/дорівнює нулю");
            return;
        }
        else
        {
            this.a = a;
            this.b = b;
            this.h_a = h_a;
        }
    }

    public override double perimeter()
    {
        return (a + b) * 2;
    }

    public override double area()
    {
        return a * h_a;
    }
}

class Trapeze : Figure
{
    int a;
    int b;
    int c;
    int d;
    int h;
    public Trapeze(int a, int b, int c, int d, int h)
    {
        if (a <= 0 || b <= 0 || c <= 0 || d <= 0 || h <= 0)
        {
            Console.WriteLine("Одна із змінних менша/дорівнює нулю");
            return;
        }
        else
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.h = h;
        }
    }

    public override double perimeter()
    {
        return a + b + c + d;
    }

    public override double area()
    {
        return (a+b)/2 * h;
    }
}

class Circle : Figure
{
    const double Pi = 3.14;
    int r;
    public Circle(int r)
    {
        if (r <= 0)
        {
            Console.WriteLine("Одна із змінних менша/дорівнює нулю");
            return;
        }
        else
        {
            this.r = r;
        }
    }

    public override double perimeter()
    {
        return 2 * Pi * r;
    }

    public override double area()
    {
        return Pi * r * r;
    }
}


class Ellipse : Figure
{
    const double Pi = 3.14;
    int a;
    int b;
    public Ellipse(int a, int b)
    {
        if (a <= 0 || b <= 0)
        {
            Console.WriteLine("Одна із змінних менша/дорівнює нулю");
            return;
        }
        else
        {
            this.a = a;
            this.b = b;
        }
    }

    public override double perimeter()
    {
        return  Pi * a * b;
    }

    public override double area()
    {
        return 4*((Pi * a * b + Math.Pow((a - b),2)) - a + b);
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Для стоврення фігури напишіть її назву:");
        Console.WriteLine("Квадрат \nПрямокутник \nТрикутник \nРомб \nПаралелограм \nТрапейція \nКоло \nЕліпс");
        name = Console.ReadLine();
        int sw, a, b, c, d, h;
        switch(name)
        {
            case "Квадрат":
                Console.Clear();
                Console.WriteLine("Введіть сторону квадрату:");
                a = Convert.ToInt32(Console.ReadLine());
                Square sq = new Square(a);
                Console.WriteLine("Виберіть що потрібно порахувати:");
                Console.WriteLine("1 - Периметр \n2 - Площа \n3 - 1 і 2");
                sw = Convert.ToInt32(Console.ReadLine());
                switch (sw) 
                {
                    case 1:
                        Console.WriteLine("Периметр квадрата {0}",sq.perimeter());
                        break;
                    case 2:
                        Console.WriteLine("Площа квадрата {0}", sq.area());
                        break;
                    case 3:
                        Console.WriteLine("Периметр квадрата {0}", sq.perimeter());
                        Console.WriteLine("Площа квадрата {0}", sq.area());
                        break;
                    default:
                        Console.WriteLine("Введено хібні дані");
                        break;
                }
                break;
            case "Прямокутник":
                Console.Clear();
                Console.WriteLine("Введіть довжину прямокутника:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть ширину прямокутника:");
                b = Convert.ToInt32(Console.ReadLine());
                Rectangle rg = new Rectangle(a,b);
                Console.WriteLine("Виберіть що потрібно порахувати:");
                Console.WriteLine("1 - Периметр \n2 - Площа \n3 - 1 і 2");
                sw = Convert.ToInt32(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        Console.WriteLine("Периметр прямокутника {0}", rg.perimeter());
                        break;
                    case 2:
                        Console.WriteLine("Площа прямокутника {0}", rg.area());
                        break;
                    case 3:
                        Console.WriteLine("Периметр прямокутника {0}", rg.perimeter());
                        Console.WriteLine("Площа прямокутника {0}", rg.area());
                        break;
                    default:
                        Console.WriteLine("Введено хібні дані");
                        break;
                }
                break;

            case "Трикутник":
                Console.Clear();
                Console.WriteLine("Введіть першу сторону трикутника:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть дургу сторону трикутника:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть першу сторону трикутника:");
                c = Convert.ToInt32(Console.ReadLine());
                Triangle tr = new Triangle(a, b, c);
                Console.WriteLine("Виберіть що потрібно порахувати:");
                Console.WriteLine("1 - Периметр \n2 - Площа \n3 - 1 і 2");
                sw = Convert.ToInt32(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        Console.WriteLine("Периметр трикутника {0}", tr.perimeter());
                        break;
                    case 2:
                        Console.WriteLine("Площа трикутника {0}", tr.area());
                        break;
                    case 3:
                        Console.WriteLine("Периметр трикутника {0}", tr.perimeter());
                        Console.WriteLine("Площа трикутника {0}", tr.area());
                        break;
                    default:
                        Console.WriteLine("Введено хібні дані");
                        break;
                }
                break;

            case "Ромб":
                Console.Clear();
                Console.WriteLine("Введіть сторону ромба:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть висоту ромба:");
                h = Convert.ToInt32(Console.ReadLine());
                Romb romb = new Romb(a, h);
                Console.WriteLine("Виберіть що потрібно порахувати:");
                Console.WriteLine("1 - Периметр \n2 - Площа \n3 - 1 і 2");
                sw = Convert.ToInt32(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        Console.WriteLine("Периметр ромба {0}", romb.perimeter());
                        break;
                    case 2:
                        Console.WriteLine("Площа ромба {0}", romb.area());
                        break;
                    case 3:
                        Console.WriteLine("Периметр ромба {0}", romb.perimeter());
                        Console.WriteLine("Площа ромба {0}", romb.area());
                        break;
                    default:
                        Console.WriteLine("Введено хібні дані");
                        break;
                }
                break;

            case "Паралелограм":
                Console.Clear();
                Console.WriteLine("Введіть сторону паралелограма:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть висоту від сторони паралелограма:");
                h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть другу сторону паралелограма:");
                b = Convert.ToInt32(Console.ReadLine());
                Parallelogram pal = new Parallelogram(a, b, h);
                Console.WriteLine("Виберіть що потрібно порахувати:");
                Console.WriteLine("1 - Периметр \n2 - Площа \n3 - 1 і 2");
                sw = Convert.ToInt32(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        Console.WriteLine("Периметр паралелограма {0}", pal.perimeter());
                        break;
                    case 2:
                        Console.WriteLine("Площа паралелограма {0}", pal.area());
                        break;
                    case 3:
                        Console.WriteLine("Периметр паралелограма {0}", pal.perimeter());
                        Console.WriteLine("Площа паралелограма {0}", pal.area());
                        break;
                    default:
                        Console.WriteLine("Введено хібні дані");
                        break;
                }
                break;

            case "Трапеція":
                Console.Clear();
                Console.WriteLine("Введіть нижню основу трапеції:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть верхню основу трапеції:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть першу бокову сторону трапеції:");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть другу бокову сторону трапеції:");
                d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть висоту трапеції:");
                h = Convert.ToInt32(Console.ReadLine());
                Trapeze trap = new Trapeze(a, b, c, d, h);
                Console.WriteLine("Виберіть що потрібно порахувати:");
                Console.WriteLine("1 - Периметр \n2 - Площа \n3 - 1 і 2");
                sw = Convert.ToInt32(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        Console.WriteLine("Периметр трапеції {0}", trap.perimeter());
                        break;
                    case 2:
                        Console.WriteLine("Площа трапеції {0}", trap.area());
                        break;
                    case 3:
                        Console.WriteLine("Периметр трапеції {0}", trap.perimeter());
                        Console.WriteLine("Площа трапеції {0}", trap.area());
                        break;
                    default:
                        Console.WriteLine("Введено хібні дані");
                        break;
                }
                break;

            case "Коло":
                Console.Clear();
                Console.WriteLine("Введіть радіус кола:");
                a = Convert.ToInt32(Console.ReadLine());
                Circle cir = new Circle(a);
                Console.WriteLine("Виберіть що потрібно порахувати:");
                Console.WriteLine("1 - Периметр \n2 - Площа \n3 - 1 і 2");
                sw = Convert.ToInt32(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        Console.WriteLine("Периметр кола {0}", cir.perimeter());
                        break;
                    case 2:
                        Console.WriteLine("Площа кола {0}", cir.area());
                        break;
                    case 3:
                        Console.WriteLine("Периметр кола {0}", cir.perimeter());
                        Console.WriteLine("Площа кола {0}", cir.area());
                        break;
                    default:
                        Console.WriteLine("Введено хібні дані");
                        break;
                }
                break;

            case "Еліпс":
                Console.Clear();
                Console.WriteLine("Введіть велику піввісь еліпса:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть малу піввісь еліпса:");
                b = Convert.ToInt32(Console.ReadLine());
                Ellipse el = new Ellipse(a, b);
                Console.WriteLine("Виберіть що потрібно порахувати:");
                Console.WriteLine("1 - Периметр \n2 - Площа \n3 - 1 і 2");
                sw = Convert.ToInt32(Console.ReadLine());
                switch (sw)
                {
                    case 1:
                        Console.WriteLine("Периметр еліпса {0}", el.perimeter());
                        break;
                    case 2:
                        Console.WriteLine("Площа еліпса {0}", el.area());
                        break;
                    case 3:
                        Console.WriteLine("Периметр еліпса {0}", el.perimeter());
                        Console.WriteLine("Площа еліпса {0}", el.area());
                        break;
                    default:
                        Console.WriteLine("Введено хібні дані");
                        break;
                }
                break;
        }
    }
}