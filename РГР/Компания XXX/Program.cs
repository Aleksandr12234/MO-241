internal class Program
{
    private static void Main(string[] args)
    {
        //компания ХХХ (ввод через фаил, вывод через консоль)

        //Считываание с фаила
        string[] array=[];
        try{
            string list="";
            StreamReader file=new StreamReader("vvod\\input_s1_08.txt");

            string a=""+file.ReadLine();
            while(!a.Equals("")){
                list+=a+"\n";
                a=""+file.ReadLine();
            }

            array=list.Split("\n");
            file.Close();
        }catch(Exception){}
        
        //поиск номера начальника
        int nach=0;
        try{
            nach=Convert.ToInt32(array[array.Length-2]);
        }catch(Exception){
            foreach(string i in array){
                if( (" "+array[array.Length-2]).Equals(i.Substring(4)) ){
                    nach=Convert.ToInt32(i.Substring(0,4));
                    break;
                }
            }
        }

        //начальник и подчиненые
        string[] result= search(array, nach).Split("\n");
        //только подчиненые (в правильном порядке)
        int[] res2=new int[result.Length-1];
        for(int i=1; i<result.Length; i++){
            res2[i-1]=Convert.ToInt32(result[i]);
        }
        Array.Sort(res2);

        //запись массивом номера и имена подчиненых
        result=new string[res2.Length];
        for(int i=0; i<result.Length; i++){
            result[i]="";
            for(int k=0; k<array.Length-3; k++){
                int b=Convert.ToInt32(array[k].Substring(0,4));
                if(b==res2[i] && result[i].Length<array[k].Length){
                    result[i]=array[k];
                }
            }
        }

        //вывод
        foreach(string i in result){
            Console.WriteLine(
                i.Length==4 ? i+" Unknown Name" : i
                );
        }
    }

    static string search(string[] array, int necessary){
        string ret=""+necessary;

        for(int i=0; i<array.Length-3; i+=2){
            int b=Convert.ToInt32(array[i].Substring(0,4));//номер обрабатываемого главного
            if(b==necessary){
                ret +="\n"+search(array, Convert.ToInt32(array[i+1].Substring(0,4)));
            }
            
        }

        return ret;
    }
}