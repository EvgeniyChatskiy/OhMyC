int [] array = { 1, 12, 31, 4, 18, 16, 71, 18 };

int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}