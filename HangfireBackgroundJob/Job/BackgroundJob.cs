using Hangfire;
using Prometheus;

namespace HangfireBackgroundJob.Job;

public class BackgroundJobs(ILogger<BackgroundJobs> logger)
{
    private readonly ILogger<BackgroundJobs> _logger = logger;
    private static readonly Counter _jobExecutionCounter = Metrics.CreateCounter(
        "hangfire_background_job_executions_total",
        "Counts the total number of Hangfire background job executions",
        new CounterConfiguration
        {
            LabelNames = ["BackgroundJob"]
        });

    public Task StartJob()
    {
        _jobExecutionCounter.WithLabels("StartJob").Inc();
        _logger.LogInformation("Hey, I Working - {Time}", DateTime.UtcNow);
        return Task.CompletedTask;
    }

    public static void ScheduleRecurringJobs()
    {
        RecurringJob.AddOrUpdate<BackgroundJobs>(
            "StartJob",
            job => job.StartJob(),
            Cron.Daily(18, 5)
        );
    }
}