
class Program(){
    static int[] masiv= new int[0];

    static void Main(){
        masiv=Input();

        masiv=Processing(masiv);

        Output(masiv);

    }

    static int[] Input(){
        Console.WriteLine("Введите количество элементов: ");
        int[] a=new int[ Convert.ToInt32(Console.ReadLine()) ];

        for(int i=0; i<a.Length; i++){
            Console.WriteLine("Введите элемент: ");
            a[i]=Convert.ToInt32(Console.ReadLine());
        }

        return a;
    }

    static int[] Processing(int[] a){

        for(int i=0; i<a.Length; i++){
            a[i]=a[i]*a[i];
        }

        return a;
    }

    static void Output(int[] a){
        Console.WriteLine("Результат:");

        foreach(int i in a){
            Console.Write($"{i}; ");
        }
    }
}