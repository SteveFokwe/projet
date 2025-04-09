using CabloBackEnd.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//add cors policy
builder.Services.AddCors(opt => {
    opt.AddPolicy("CorsPolicy", policyBuilder => {
        policyBuilder.AllowAnyHeader()
                      .AllowAnyMethod().WithOrigins("http://localhost:3000");
    });
});

builder.Services.AddControllers();
builder.Services.AddHttpClient<ClientController>();
builder.Services.AddHttpClient<OperationController>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
