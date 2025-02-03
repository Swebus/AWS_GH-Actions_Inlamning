namespace string_crypter
{
    public class Decrypter
    {
        public static string DecryptString(string input)
        {
            char[] vowels = { 'a', 'e', 'y', 'u', 'i'};
            string outputString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char charToCheck = input[i];
                if (vowels.Contains(charToCheck) | !char.IsLetter(charToCheck))
                {
                    outputString += charToCheck;

                }
                else if (!vowels.Contains(charToCheck) && charToCheck == input[i + 2] && input[i + 1] == 'o')
                {
                    outputString += charToCheck;
                    i += 2;
                }
                
                else if (charToCheck == 'o')
                {
                    outputString += charToCheck;
                  
                }
            }

            return outputString;
        }
    }
}
