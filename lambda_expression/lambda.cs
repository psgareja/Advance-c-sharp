class Program {
    public delegate string GetTextDelegate(string name);

    static void Main(string[] args){
        GetTextDelegate getTextDelegate=delegate(string name){
return "Hello"+name;
        };
        Console.WriteLine(getTextDelegate("Pradip"));

        //Lambda Expression
        GetTextDelegate getHelloText=(string name)=> {return name;};
        Console.WriteLine(getHelloText("Pradip"));


        //statement lambda 
        GetTextDelegate getGoodby=(string name)=>{
            Console.WriteLine("Hello");
            return name;
        }

        GetTextDelegate getWelcome=name=>"welcome"+name;
    }

}