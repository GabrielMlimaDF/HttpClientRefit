using HttpClientApi.Controller;
using HttpClientApi.Integration;
using HttpClientApi.Integration.Interfaces;
using HttpClientApi.Integration.Refit;
using Microsoft.AspNetCore.Builder;
using Refit;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddRefitClient<ICepRefit>().ConfigureHttpClient(c => c.BaseAddress = new Uri("https://viacep.com.br"));
builder.Services.AddScoped<ICepIntegracao, IntegrationCep>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.Run();
