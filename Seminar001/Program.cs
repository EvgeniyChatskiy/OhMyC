Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
    num *= -1; //num = num * (-1)

int endNum = num * -1;

while (num <= endNum) {
    Console.Write(num);

    if (num < endNum)
    Console.Write(", ");
    
    num++;
}