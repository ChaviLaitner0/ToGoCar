using Bl;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<BlManager>();

var app = builder.Build();
app.MapControllers();
app.MapGet("/", () => "Hello World!");



app.UseHttpsRedirection();

app.UseCors();
app.Run();
