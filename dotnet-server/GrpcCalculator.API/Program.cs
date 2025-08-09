using GrpcCalculator.Application.Interfaces;
using GrpcCalculator.Application.Services;
using GrpcCalculator.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();

// Add Application & Infrastructure services
builder.Services.AddScoped<ICalculatorService,CalculatorService>();
builder.Services.AddScoped<GrpcCalculatorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GrpcCalculatorService>();
app.MapGet("/", () => "This server hosts gRPC Calculator Service.");

app.Run();
