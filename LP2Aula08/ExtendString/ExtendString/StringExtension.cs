
public static class StringExtension
{

    private static readonly Random random = new Random();

    public static string ToRandomCase(string s)
    {
        // randomizar o chr na string

        foreach (char character in s)
        {

            // if random value, apply upper case
            if (random.next(0, 2) == 0)
            {
                //character.ToUpper();
            }
            else
            {
               // character.ToLower();
            }
           
        }


        // devolver a string com os chars randomizados 
        return s;


    }

}


