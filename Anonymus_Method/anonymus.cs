class Program {
    public delegate string GetTextDelegate(string name);

    static void Main(string[] args){
        GetTextDelegate getTextDelegate=delegate(string name){
return "Hello"+name;
        };
        Console.WriteLine(getTextDelegate("Pradip"));

    }

}