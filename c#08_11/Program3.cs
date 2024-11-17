internal class Program3
{
    private static void Main(string[] args)
    {
        //опр номера строк элементы которых элементы которых образуют равномерно убывающую последовательность
        
        Console.Write("Введите количество строк: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int m = Convert.ToInt32(Console.ReadLine());

        double[,] array = new double[n, m];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"строка {i + 1}:");
            for (int k = 0; k < m; k++)
            {
                array[i,k] = Convert.ToDouble(Console.ReadLine());
            }
        }

        Console.WriteLine("Введёный массив:");
        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < m; k++)
            {
                Console.Write(array[i, k] + " ");
            }
            Console.WriteLine();
        }

        
        string s="";
        for(int i=0; i<n; i++){
            double b=array[i,1]-array[i,0];
            double q=array[i,1]/array[i,0];
            if(b>=0)continue;
            else if(m==2) s+=" "+(i+1);
            for(int k = 2; k<m && (array[i,k]-array[i,k-1]==b || array[i,k]/array[i,k-1]==q); k++){
                if(k==m-1)s+=" "+(i+1);
            }
        }

        Console.WriteLine("Ответ:" + (s==""? "нету":s));
    }
}