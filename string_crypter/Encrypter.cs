using System.Text.RegularExpressions;

namespace string_crypter
{
    public class Encrypter
    {
        public static string EncryptString(string input)
        {
            char[] vowels = {'a', 'e', 'y', 'u', 'i', 'o'};
            string outputString = "";

            foreach (var item in input) 
            { 
                if (vowels.Contains(item) | (!char.IsLetter(item)))
                {
                    outputString = outputString + item.ToString();
                }
                else if (!vowels.Contains(item))
                {
                    
                    string encrypterLetter = item.ToString() + "o" + item.ToString();
                    outputString = outputString + encrypterLetter;
                }
            }



            return outputString;
        }



    }
}
