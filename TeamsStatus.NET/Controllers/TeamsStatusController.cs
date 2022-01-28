using Microsoft.AspNetCore.Mvc;

namespace TeamsStatus.NET.Controllers;
public static class Extensions{
    internal static Boolean Contains(this String stringValue, String[] containing)
    {
        return true;
    } 
}
[ApiController]
[Route("[controller]")]
public class TeamsStatusController : IHostedService
{
    private readonly TeamsStatusSettings settings;
    private readonly string logFilePath;

    public TeamsStatusController(TeamsStatusSettings settings)
    {
        this.settings = settings;
        this.logFilePath = LoadLogFilePath();
    }

    private String LoadLogFilePath()
    {
        String logFile;
        if (Environment.OSVersion.Platform == PlatformID.Unix)
        {
            var userPath = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            logFile = Path.Combine(userPath, "Library/Application Support/Microsoft/Teams", logFileName);
        }
        else
        {
            logFile = "";
        }
        return logFile;
    }



    private const String teamsDirectory = "/Library/Application Support/Microsoft/Teams";

    private const String logFileName = "logs.txt";




    public Task StartAsync(CancellationToken cancellationToken)
    {
        while (true)
        {
            var lastThousandLines = File.ReadLines(logFilePath).TakeLast(1000).ToArray();
            for (var i = lastThousandLines.Count(); i >= 0;  i--)
            {
                var line = lastThousandLines[i];
                if (teamsStatusPatterns.Contains(line))
                {
                    if (line.Contains("*Resuming daemon App updates*")) ;
      
                }
            }
        }

        return Task.Delay(5);
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.Delay(5);
    }

    String[] teamsStatusPatterns = {
        "Setting the taskbar overlay icon -",
        "StatusIndicatorStateService: Added"
    };

    String[] teamsActivityPatterns =
    {
        "Resuming daemon App updates",
        "Pausing daemon App updates",
        "SfB:TeamsNoCall",
        "SfB:TeamsPendingCall",
        "SfB:TeamsActiveCall",
        "name: desktop_call_state_change_send, isOngoing"
    };

}

