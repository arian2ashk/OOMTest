using Scrypt;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var encoder = new ScryptEncoder();
    return encoder.Compare("mXTYa34CxNzOU54umjkl0XoE2uVI8JOx5kvs9RE4Ow2", "$s2$16384$8$1$lIyDgxtMXMZ27rdz+JsyApCZ/bf7lnZzo7URhUGRBsM=$MmdQON66j1M0D8u3wKbi7lX5cNyTZZPLX5GKqRxLY+o=");
}).Produces<bool>();

app.Run();