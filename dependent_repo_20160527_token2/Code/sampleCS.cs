var outlookClient = await CreateOutlookClientAsync("Calendar");
var events = await outlookClient.Me.Events
  .Take(10)
  .ExecuteAsync();
foreach(var calendarEvent in events.CurrentPage)
{
  System.Diagnostics.Debug.WriteLine("Event '{0}'.", calendarEvent.Subject);
}