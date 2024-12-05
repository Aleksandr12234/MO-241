internal class Program2
{
    private static void Main(string[] args)
    {
        //опр для каждой строки наименьшую длину подпоследовательности, состоящую из равномерно убывающих элементов (под последовательность с двумя эл-ами и больше)

        //ввод
        Console.Write("Введите количество строк: ");
        int countString = Convert.ToInt32(Console.ReadLine());
        int [][] arr=new int[countString][];
        for(int i=0; i<countString; i++){
            Console.WriteLine($"Введите строку {i+1} (все элементы через пробел): ");
            arr[i]=Input();
        }

        //вывод
        for(int i=0; i<arr.Length; i++){

            int b=0;
            int n=1;
            int minN=0;
            bool zadan= false;

            for(int j=1; j<arr[i].Length; j++){
                if(arr[i][j]-arr[i][j-1]==b && b<0)n++;
                else {
                    if(!zadan && n>1){minN=n; zadan=true;}
                    else if(n>1)minN=Math.Min(n, minN);
                    n=1;
                    b=arr[i][j]-arr[i][j-1];
                }
            }
            if(!zadan && n>1){minN=n; zadan=true;}
            else if(n>1)minN=Math.Min(n, minN);

            if(zadan)Console.WriteLine($"В строке {i+1} наименьшая длинна равномерно убывающей последовательности равна: {minN+1}");
            else Console.WriteLine($"В строке {i+1} равномерно убывающей последовательности нет");
        }
    }

    static int[] Input(){

        string s=""+Console.ReadLine();

        string[] q = s.Split(" ");
        int[] res=new int[q.Length];

        for(int i=0; i<res.Length; i++){
            res[i]=Convert.ToInt32(q[i]);
        }

        return res;
    }
}