using System;
namespace TeamsStatus.NET
{
	public class TeamsStatusSettings
	{
		public TeamsStatusSettings()
		{
		}
        public String HomeAssistantToken { get; set; }
        public String UserName { get; set; }
        public  String HomeAssistantUrl { get; set; }
		
//# Set language variables below
//$lgAvailable = "Available"
//$lgBusy = "Busy"
//$lgOnThePhone = "On the phone"
//$lgAway = "Away"
//$lgBeRightBack = "Be right back"
//$lgDoNotDisturb = "Do not disturb"
//$lgPresenting = "Presenting"
//$lgFocusing = "Focusing"
//$lgInAMeeting = "In a meeting"
//$lgOffline = "Offline"
//$lgNotInACall = "Not in a call"
//$lgInACall = "In a call"

//# Set icons to use for call activity
//$iconInACall = "mdi:phone-in-talk-outline"
//$iconNotInACall = "mdi:phone-off"
//$iconMonitoring = "mdi:api"

//# Set entities to post to
//$entityStatus = "sensor.teams_status"
//$entityStatusName = "Microsoft Teams status"
//$entityActivity = "sensor.teams_activity"
//$entityActivityName = "Microsoft Teams activity"
//$entityHeartbeat = "binary_sensor.teams_monitoring"
//$entityHeartbeatName = "Microsoft Teams monitoring"
	}
}

