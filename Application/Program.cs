
using string_crypter;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "To encrypt a string is the following endpoint: ?input=<stringtoencrypt> \n\n" +
"To decrypt a string is the following endpoint: ?input=<stringtodecrypt>");

app.MapGet("/Encrypt", (string input) => Encrypter.EncryptString(input));

app.MapGet("/Decrypt", (string input) => Decrypter.DecryptString(input));

app.Run();
