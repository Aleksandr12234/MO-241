using System.Diagnostics.Metrics;

internal class Program1
{
    private static void Main(string[] args)
    {
        //определить пары номеров столбцов в которых стоят одинаковые элементы (сортировать нельзя)
        Console.Write("Введите количество строк: ");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int m=Convert.ToInt32(Console.ReadLine());

        int[,] array=new int[n,m];

        for(int i=0; i<m; i++){
            Console.WriteLine($"столбец {i+1}:");
            for(int k=0; k<n; k++){
                array[k,i]=Convert.ToInt32(Console.ReadLine());      
            }
        }

        Console.WriteLine("Введёный массив:");
        for(int i=0; i<n; i++){
            for(int k=0; k<m; k++){
                Console.Write(array[i,k]+" ");
            }
            Console.WriteLine();
        }


        for(int k=0; k<m; k++){
            int sum1=0;
            int p1=1;
            int zeroCounte=0;
            for(int i=0; i<n; i++){
                sum1+=array[i,k];
                p1*=array[i,k]==0 ? 1:array[i,k];
                if(array[i,k]==0)zeroCounte+=1;
            }

            Console.Write("одинаковые с "+(k+1)+":");

            bool b=false;
            for(int k1=0; k1<m; k1++){
                if(k1==k)continue;
                int sum2=0;
                int p2=1;
                int zeroCounte2=0;
                for(int i=0; i<n; i++){
                    sum2+=array[i,k1];
                    p2*=array[i,k1]==0 ? 1:array[i,k1];
                    if(array[i,k1]==0)zeroCounte2+=1;
                }
                if(sum1==sum2 && p1==p2 && zeroCounte==zeroCounte2){
                    Console.Write(" "+(k1+1));
                    b=true;
                }
            }
            Console.WriteLine(b ? "":" нету");
        }

    }
}