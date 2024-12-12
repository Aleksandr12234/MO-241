internal class Program
{
    private static void Main(string[] args)
    {
        //Определить является ли Массив последовательностью равномерно убывающих элементов (532 531)

        Console.Write("Введите количество элементов: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] array=new int[n];

        for(int i=0; i<array.Length; i++){
            Console.Write($"Введите элемент {i+1}: ");
            n=Convert.ToInt32(Console.ReadLine());
            array[i]=n;
        }

        if(array.Length<2){
            Console.WriteLine("Не является");
            return;
        }

        int b=array[0]-array[1];

        if(b<=0){
            Console.WriteLine("Не является");
            return;
        }

        for(int i=1; i<array.Length; i++){
            if(array[i-1]-array[i]!=b){
                Console.WriteLine("Не является");
                return;
            }
        }
        
        Console.WriteLine("Является");
    }
}