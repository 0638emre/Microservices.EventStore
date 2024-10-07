using Product.EventHandler.Service.Services;
using Shared.Services;
using Shared.Services.Abstractions;

var builder = Host.CreateApplicationBuilder(args);
// builder.Services.AddHostedService<Worker>();
builder.Services.AddHostedService<EventStoreBackgroundService>();

builder.Services.AddSingleton<IEventStoreService, EventStoreService>();
builder.Services.AddSingleton<IMongoDBService, MongoDBService>();

var host = builder.Build();
host.Run();