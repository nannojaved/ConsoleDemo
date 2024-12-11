namespace Types_Of_Methods;
// Instance Method
// static Method

class Program
{
    static void Main(string[] args)
    {
        // Instance elev
        Elev elev = new Elev(); // for å lage Object elev
        
        elev.Name = "BHV";

        // Instance Method
        elev.MyName();

        // Kan brukes flere ganger
        // dvs kan lage flere instance
        Elev nyElev = new Elev();
        nyElev.Name = "2IT";


        // Instance Method
        nyElev.MyName();

        Console.WriteLine("Hello, World!");

        string tall = "50";
        int mytall = Convert.ToInt32(tall);
    }
}

