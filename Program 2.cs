// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

/*
python
def count(n):
    if n == 0:
        print("0")
    else:
        print(n)
        count(n - 1)

#number = count(99)*/


// C#

void count(int n)
{
    if (n == 0)
    {
        Console.WriteLine("0");
    }
    else
    {
        Console.WriteLine(n);
        count(n - 1);
    }
}

void Main(string[] args)
{
    count(99);
}




/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*Python
def summrange(m, n):
    summ = 0
    for i in range(m, n+1):
        summ += i
    return summ

# sumrang = summrange(1,5)
# print(sumrang)*/


// C#
void SummRange(int m, int n)
{
    int summ = 0;
    for (int i = m; i <= n; i++)
    {
        summ += i;
    }
    return summ;
}

void Main(string[] args)
{
    int sumrang = SummRange(1, 5);
    Console.WriteLine(sumrang);
}




















/*Python

def ackerman(m,n):
    if m == 0:
        return n + 1

    elif n==0:
        return ackerman(m - 1, 1)

    else:
        return ackerman(m-1, ackerman(m, n - 1))
ask = ackerman(3,3)
print(ask)*/



void Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

void Main()
{
    int ask = Ackerman(3, 3);
    Console.WriteLine(ask);
}










// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


/*Python
def ackerman(m,n):
    if m == 0:
        return n + 1

    elif n==0:
        return ackerman(m - 1, 1)

    else:
        return ackerman(m-1, ackerman(m, n - 1))
ask = ackerman(3,3)
print(ask)*/



