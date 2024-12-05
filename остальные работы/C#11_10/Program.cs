Console.WriteLine("Введите число:");
int a=Convert.ToInt32(Console.ReadLine());

while(a>0){
    int b=a;
    int c=0;
    bool d=false;
    int i=0;

    while(b>0){

        if(b%2!=0) {
            c=(int)(c*Math.Pow(10, i)+(b%10));
            d=true;
            i++;
        }
        
        b/=10;
    }

    Console.WriteLine(d ? c : "Нет нечётных элементов");
    Console.WriteLine("Введите число:");
    a=Convert.ToInt32(Console.ReadLine());
}