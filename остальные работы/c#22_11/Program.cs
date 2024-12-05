using System.IO.Compression;
using System.Runtime.Serialization.Formatters;

internal class Program
{
    private static void Main(string[] args)
    {
        //опр номера строк массива в котором имеется элемент, значение которого > суммы всех элементов строки
        
        //ввод
        Console.Write("Введите количество строк: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int [][] arr=new int[n][];
        for(int i=0; i<n; i++){
            Console.WriteLine($"Введите строку {i+1} (все элементы через пробел): ");
            arr[i]=Input();
        }
        
        //вывод
        Console.Write("Ответ:");
        for(int i=0; i<n; i++){
            int maxElement=arr[i].Max();
            int sumOfElements=arr[i].Sum()-maxElement;
            if(maxElement>sumOfElements)Console.Write($" {i+1}");
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