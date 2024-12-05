using System;

class Program2{
    static void Main(){
        Console.WriteLine("Введите кол-во элементов:");
        int n=Convert.ToInt32(Console.ReadLine());

        int k=0;
        int kMin=-1;
        for(int i=0; i<n; i++){
            Console.WriteLine("Введите элемент:");
            int a=Convert.ToInt32(Console.ReadLine());

            if(Math.Abs(a)%2==0){
                k++;
            }
            else{
                if (kMin==-1 && k!=0)kMin=k;
                else if(k!=0)kMin=Math.Min(k, kMin);
                k=0;
            }
        }
        if (kMin==-1)kMin=k;
        else if(k!=0)kMin=Math.Min(k, kMin);

        Console.WriteLine("Ответ: "+kMin);
    }
}