var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuracion de CORS
builder.Services.AddCors(policyBuilder => policyBuilder.AddDefaultPolicy
    (policy => policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod()));


builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseCors(); //Habilitar CORS

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
