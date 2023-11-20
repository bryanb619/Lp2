using System.IO;
class Program
{
    static void Main(string[] args)
    {

        using (StreamReader sr = new StreamReader("data.txt"))
        {
            string line;


            int numberOfWords = allWords.Count ( words => words.characters > 30);

            /*
            For each line thas has more than 30 characters, print the quantity of lines



            foreach (string line in lines)
            {
                if (line.Length > 30)
                {
                    Console.WriteLine(line);
                }
            }


            */

            while ((line = sr.ReadLine()) != null)
            {
            
                if(line != null)
                

                    Console.WriteLine(line);
                }
                
            }

        }

       
        
    }


}