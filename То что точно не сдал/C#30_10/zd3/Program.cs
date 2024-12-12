internal class Program
{
    private static void Main(string[] args)
    {
        //Определить все ли элементы четные (да/нет)

        Console.Write("Введите количество элементов: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] array=new int[n];

        for(int i=0; i<array.Length; i++){
            Console.Write($"Введите элемент {i+1}: ");
            n=Convert.ToInt32(Console.ReadLine());
            array[i]=n;
        }

        if(array.Length==0){
            Console.WriteLine("В массиве элементов нет");
            return;
        }

        for(int i=0; i<array.Length; i++){
            if(array[i]%2!=0){
                Console.WriteLine("В массиве не все элементы четные");
                return;
            }
        }

        Console.WriteLine("В массиве все элементы четные");
    }
}