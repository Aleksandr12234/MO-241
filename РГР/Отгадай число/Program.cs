internal class Program
{
    private static void Main(string[] args)
    {
        //отгадай число (ввод через фаил, вывод через консоль)

        //ввод
        string[] array=[];
        try{
            StreamReader file=new("vvod\\input_s1_08.txt");

            string list="";
            string a=""+file.ReadLine();
            while(!a.Equals("")){
                list+=a+"\n";
                a=""+file.ReadLine();
            }
            array=list.Split("\n");
            file.Close();
        }catch(Exception){}

        //алгоритм
        int countOfX = 1;
        int countOfUnit = 0;

        for(int i=1; i<array.Length-2; i++){
            switch(array[i].Substring(0,1)){
                case "+":
                    if(array[i].Substring(2)=="x") countOfX++;
                    else countOfUnit+= Convert.ToInt32(array[i].Substring(2));
                break;
                case "-":
                    if(array[i].Substring(2)=="x") countOfX--;
                    else countOfUnit-= Convert.ToInt32(array[i].Substring(2));
                break;
                case "*":
                    countOfX*=Convert.ToInt32(array[i].Substring(2));
                    countOfUnit*=Convert.ToInt32(array[i].Substring(2));
                break;
            }
        }

        //вывод
        int result=(Convert.ToInt32(array[array.Length-2])- countOfUnit)/countOfX;
        Console.WriteLine("вывод: "+result);
    }
}