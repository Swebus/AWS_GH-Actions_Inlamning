
using string_crypter;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "To encrypt a string use the following endpoint: /Encrypt?input=<stringtoencrypt> \n\n" +
"To decrypt a string use the following endpoint: /Decrypt?input=<stringtodecrypt>");

app.MapGet("/Encrypt", (string input) => Encrypter.EncryptString(input));

app.MapGet("/Decrypt", (string input) => Decrypter.DecryptString(input));

app.Run();
