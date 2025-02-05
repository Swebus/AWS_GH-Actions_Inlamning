
using string_crypter;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "To encrypt a string is the following endpoint: ?inputString=<stringtoencrypt>");


app.MapGet("/Encrypt", (string inputString) => Encrypter.EncryptString(inputString));

app.Run();
