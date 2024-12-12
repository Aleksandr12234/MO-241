class Cars{
    public string marka;
    public string ear;
    public string color;
    public string countryOfVipuska;

    public Cars(string[] a){
        marka=a[0];
        ear=a[1];
        color=a[2];
        countryOfVipuska=a[3];
    }

    public void Output(){
        Console.WriteLine("марка: "+marka+"; год выпуска: "+ear+"; цвет: "+color+"; страна выпуска: "+ countryOfVipuska);
    }
}