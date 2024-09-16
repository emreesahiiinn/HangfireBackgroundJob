using Hangfire;
using Hangfire.Redis.StackExchange;
using HangfireBackgroundJob.Job;
using Prometheus;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddHangfire(config =>
{
    config.UseRedisStorage("localhost:6379");
});

builder.Services.AddHangfireServer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.UseHangfireDashboard();

app.UseMetricServer();

BackgroundJobs.ScheduleRecurringJobs();

app.MapControllers();

app.Run();