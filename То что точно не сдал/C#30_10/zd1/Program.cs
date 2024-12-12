internal class Program
{
    private static void Main(string[] args)
    {
        //сформировать выходной массив сначала + потом - элементы ( сортировку использовать нельзя)
        Console.Write("Введите количество элементов: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] array=new int[n];

        for(int i=0; i<array.Length; i++){
            Console.Write($"Введите элемент {i+1}: ");
            n=Convert.ToInt32(Console.ReadLine());
            array[i]=n;
        }

        int[] array2=new int[array.Length];

        int a=0;//положительные
        int b=array2.Length-1;//отрицательные
        for(int i=0; i<array.Length; i++){
            if(array[i]<0){
                array2[b]=array[i];
                b--;
            }else if(array[i]>=0){
                array2[a]=array[i];
                a++;
            }
        }

        foreach(int i in array2){
            Console.Write(i+" ");
        }
    }
}