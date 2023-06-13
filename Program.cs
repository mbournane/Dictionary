namespace Dictionary;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<char,string> dictionary = new Dictionary<char,string>();
        dictionary['a'] = "Automobile";
        dictionary['b'] = "Bateau";
        dictionary['c'] = "Camion";

        dictionary.Remove('c');
        for (int i = 0; i < dictionary.Count; i++)
                    Console.WriteLine("Key: {0}, Value: {1}", dictionary.ElementAt(i).Key, dictionary.ElementAt(i).Value);                                                    
                                                    


    }
}
