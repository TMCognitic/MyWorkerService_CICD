using Tools;

namespace WorkerService
{
    public class Worker(ILogger<Worker> logger) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (logger.IsEnabled(LogLevel.Information))
                {
                    Guid id = Generator.CreateGuid();
                    logger.LogInformation($"{id.ToString().ToUpper()} : Service s'exécute à : {DateTimeOffset.Now:T}");
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
