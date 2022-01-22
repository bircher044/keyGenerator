using System.Text;
class KeyGenerator
{
    string NewKey()
    {
        int length = 32;

        StringBuilder str_build = new StringBuilder();
        Random random = new Random();

        char letter;
        string key = "";

        for (int i = 0; i < length; i++)
        {
            double flt = random.NextDouble();

            int shift = Convert.ToInt32(Math.Floor(74 * flt));
            letter = Convert.ToChar(shift + 48);
            if ((letter > 57 && letter < 65) || (letter > 90 && letter < 97))
                i--;
            else
                key += letter;
        }
        return key;
    }

    static void Main()
    {
        var KeyGenerator = new KeyGenerator();

        

        Console.WriteLine(KeyGenerator.NewKey());
    }
}

