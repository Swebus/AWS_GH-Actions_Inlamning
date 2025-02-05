using string_crypter;
public class UnitTest1
{
    [Fact]
    public void TestEncrypter()
    {
        string expectedResult = "HoHejojhohopoppop, GoGumommomisosnonopoppop!";

        string testString = "Hejhopp, Gummisnopp!";
        string actualResult = Encrypter.EncryptString(testString);

        Assert.Equal(expectedResult, actualResult);
    }
    [Fact]
    public void TestDecrypter()
    {
        string expectedResult = "Hejhopp, Gummisnopp!";

        string testString = "HoHejojhohopoppop, GoGumommomisosnonopoppop!";
        string actualResult = Decrypter.DecryptString(testString);

        Assert.Equal(expectedResult, actualResult);
    }
}