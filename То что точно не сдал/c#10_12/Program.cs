internal class Program
{
    static Cars[] array=[];
    private static void Main(string[] args)
    {
        Console.Write("Введите количество машин: ");
        int n=Convert.ToInt32(Console.ReadLine());
        array=new Cars[n];

        while(true){
            Console.Clear();
            Console.WriteLine("———<Меню>———");
            Console.WriteLine($"1.Задать машину");
            Console.WriteLine("2.Вывести данные машин");
            Console.WriteLine("3.Выйти\n");

            string s=""+Console.ReadLine();
            if(s=="1"){
                Console.Write($"Введите номер ячейки, данные котрой хотите изминить (доступно 1-{array.Length} ячеек): ");
                s=""+Console.ReadLine();
                n=Convert.ToInt32(s)-1;
                if(n<0 || n>=array.Length) Console.WriteLine("Не существует ячейки с данным номером");
                else{
                    Console.Write("Введите характеристики (через пробел, марка год цвет страна): ");
                    s=""+Console.ReadLine();
                    array[n]=new Cars(s.Split(" "));
                }
            }
            else if(s=="2"){
                Console.Write("Введите по каким параметрам выовдит (через пробел, марка год цвет страна, если парметр не важн введие \"-\"): ");
                s=""+Console.ReadLine();
                string[] a=s.Split(" ");
                foreach(Cars i in array){
                    if(i==null)continue;

                    bool u=true;
                    if(!(a[0]=="-" || a[0]==i.marka)) u =false;
                    if(!(a[1]=="-" || a[1]==i.ear)) u =false;
                    if(!(a[2]=="-" || a[2]==i.color)) u =false;
                    if(!(a[3]=="-" || a[3]==i.countryOfVipuska)) u =false;

                    if(u) i.Output();
                }
            }
            else if(s=="3")break;
            else Console.WriteLine("Нет такой команды");

            Console.Write("Нажмите Enter чтобы вернуться в меню");
            Console.ReadLine();
        }
    }
}