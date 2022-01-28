using TeamsStatus.NET;
using TeamsStatus.NET.Controllers;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddHostedService<TeamsStatusController>();

var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("settings.json").Build();

var section = config.GetSection(nameof(TeamsStatusSettings));
var teamsStatusSettings = section.Get<TeamsStatusSettings>();

builder.Services.AddSingleton(teamsStatusSettings);

var app = builder.Build();

// Configure the HTTP request pipeline.



app.Run();

