//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

Console.Write("Enter \"N\" value: ");
uint m = InputGuard();
Console.Write("Enter \"M\" value: ");
uint n = InputGuard();
uint result = 0;
result = A(n, m);
Console.WriteLine($"Result:\t{result}");

uint A(uint n, uint m)
{
    if (n == 0 && m != 0)
        return m + 1;
    else if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}

uint InputGuard()
{
    uint num = 0;
    while (!uint.TryParse(Console.ReadLine(), out num) || num < 0) Console.Write("Incorrect input. Try again: ");
    return num;
}

