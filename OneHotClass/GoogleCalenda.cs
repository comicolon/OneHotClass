using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OneHotClass
{
	public class GoogleCalenda : InstanceManager
	{
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/calendar-dotnet-quickstart.json
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";
        static CalendarService service;
        static CalendarListEntry entry;

        public static void getSchedule()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            //calendar lists
            var calendarList = service.CalendarList.List().Execute().Items;

            // Display all calendars
            DisplayList(calendarList);

            foreach (CalendarListEntry calendar in calendarList)
            {
				// Display calendar's events
                if (calendar.Summary.Contains(mainForm.textBox_calendarWord.Text))
				{
				    DisplayFirstCalendarEvents(calendar);
				}
			}


            // List events.
            //Events events = request.Execute();
            //Console.WriteLine("Upcoming events:");
            //if (events.Items != null && events.Items.Count > 0)
            //{
            //    foreach (var eventItem in events.Items)
            //    {
            //        string when = eventItem.Start.DateTime.ToString();
            //        if (String.IsNullOrEmpty(when))
            //        {
            //            when = eventItem.Start.Date;
            //        }
            //        Console.WriteLine("{0} ({1})", eventItem.Summary, when);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No upcoming events found.");
            //}
            Console.Read();

        }

        // Displays all calendars
        private static void DisplayList(IList<CalendarListEntry> list)
        {
            Console.WriteLine("Lists of calendars:");
            foreach (CalendarListEntry item in list)
            {
                if (item.Summary.Contains(mainForm.textBox_calendarWord.Text))
				{
                    entry = item;
				}

                //Console.WriteLine("Id: " + item.Id);
                //Console.WriteLine("ETag: " + item.ETag);
                //Console.WriteLine("AccessRole: " + item.AccessRole);
                //Console.WriteLine("ConferenceProperties: " + item.ConferenceProperties);
                //Console.WriteLine("Description: " + item.Description);
                //Console.WriteLine("SummaryOverride: " + item.SummaryOverride);
                //Console.WriteLine("Summary: " + item.Summary);
                //Console.WriteLine("Location:" + item.Location);
                //Console.WriteLine("TimeZone:" + item.TimeZone);
                //Console.WriteLine("================================");
            }
        }

        // Displays the calendar's events
        private static void DisplayFirstCalendarEvents(CalendarListEntry list)
        {
            Console.WriteLine(Environment.NewLine + "Maximum 5 first events from {0}:", list.Summary);
			EventsResource.ListRequest request = service.Events.List(list.Id);

            //Set MaxResults and TimeMin with sample values
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // Fetch the list of events
            //foreach (Event calendarEvent in request.Execute().Items)
            //{
            //    Console.WriteLine("Summary: " + calendarEvent.Summary);
            //}

            Events events = request.Execute();
            Console.WriteLine("Upcoming events:");
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {


                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }
                    Console.WriteLine("{0} ({1})", eventItem.Summary, when);
                }
            }
            else
            {
                Console.WriteLine("No upcoming events found.");
            }
        }
    }
}
