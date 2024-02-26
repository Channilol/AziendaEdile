var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) => { 
    context.Response.ContentType = "text/html";
    return "Hello World!"; 
});

app.MapGet("/addWorker", (HttpContext context) => {
    context.Response.ContentType = "text/html";
    return "Add worker form";
});

app.MapGet("/addPayment", (HttpContext context) => {
    context.Response.ContentType = "text/html";
    return "Add payment form";
});

app.Run();