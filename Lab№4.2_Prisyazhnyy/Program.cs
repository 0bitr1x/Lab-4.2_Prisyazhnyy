//сборник задач/тема 4/подтема 4.2/вариант 19
internal class Program                                 
{                                                      
    private static void Main(string[] args)            
    {                                                  
       try {
            Console.Write("Введите количество строк n = ");
            int n = int.Parse(Console.ReadLine());         
            Console.Write("Введите количество столбцов m = ");                        
            int m = int.Parse(Console.ReadLine());         
            int[,] mas = new int[n, m];                    
            int x = 0;                                     
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || j + 1 == m) { mas[i, j] = x; x++; }
                    if (j + 1 > 1)
                    {
                        for (int k = 1; (i == 0 && k <= j && k < Math.Min(n,m)) || (j + 1 == m && k < n - i && k < Math.Min(n, m)); k++)
                        {
                            mas[i + k, j - k] = x;
                            x++;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{mas[i, j],3}");
                }
                Console.WriteLine();
            }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
        

    }
}