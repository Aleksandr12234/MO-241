internal class Program2
{
    private static void Main(string[] args)
    {
        //поменять местами столбец с максимальным элементом со столбцом минимального элемента
        Console.Write("Введите количество строк: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[n, m];

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"столбец {i + 1}:");
            for (int k = 0; k < n; k++)
            {
                array[k, i] = Convert.ToInt32(Console.ReadLine());
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

        int maxEl=array[0,0];
        int nMaxS=0;

        int minEl=array[0,0];
        int nMinS=0;

        for(int k=0; k<m; k++){
            for(int i=0; i<n; i++){
                if(maxEl<array[i,k]){
                    maxEl=array[i,k];
                    nMaxS=k;
                }
                if(minEl>array[i,k]){
                    minEl=array[i,k];
                    nMinS=k;
                }
            }
        }

        Console.WriteLine("Преобразованный массив:");
        for(int i=0; i<n; i++){
            for(int k=0; k<m; k++){
                if(nMinS==k) Console.Write(array[i,nMaxS]+" ");
                else if(nMaxS==k) Console.Write(array[i,nMinS]+" ");
                else Console.Write(array[i,k]+" ");
            }
            Console.WriteLine();
        }
    }
}