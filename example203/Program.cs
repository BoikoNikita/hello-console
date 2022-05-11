//int Factorial (int n)
//{
    //1! = 1
    //0! = 1
//    if (n==1) return 1;
//    else return n * Factorial(n-1);
//}
//Console.WriteLine(Factorial(3));

double Factorial (int n)
{
    if (n==1) return 1;
    else return n * Factorial(n-1);
}
    for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
