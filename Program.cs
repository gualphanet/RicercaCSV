namespace RicercaCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            string[] fields;

            fields = new String[4];

            try
            {
                //apertura file
                StreamReader sr = new StreamReader(args[0]);
                
                //lettura prima riga
                line = sr.ReadLine();
                
                while (line != null)
                {
                    //separazione campi riga
                    fields = line.Split(',',';');

                    //controllo match con chiave di ricerca in colonna specificata
                    if (fields[Int32.Parse(args[1])].Equals(args[2]))
                    {
                        //stampa riga in caso di match
                        Console.WriteLine(line);
                    }
                    
                    //lettura prossima riga
                    line = sr.ReadLine();
                }
                
                //chiusura file
                sr.Close();
                
            }
            //controllo errori
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            
        }
    }
}