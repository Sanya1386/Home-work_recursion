void Main()
{
    int result = Ackermann (2, 5);
    Console.WriteLine ("Результат: " + result); //когда n=2 и m=5, результат будет равен 13
 
    result = Ackermann (1, 2);
    Console.WriteLine ("Результат: " + result); //когда n=1 и m=2, результат будет равен 4
}
 
 static int Ackermann (int n, int m) => (n < 0 || m < 0) 
                        ? throw new ArgumentOutOfRangeException() 
                        : (n == 0) ? (m + 1) 
                        : (m == 0) ? Ackermann (n - 1, 1)
                        : Ackermann (n - 1, Ackermann (n, m - 1));