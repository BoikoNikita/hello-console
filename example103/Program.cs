int [] array = { 51,82,73,55,64,55,46,37,82,91 };

int n = array.Length;
int find = 55;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
