using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private List<EventModel> _events = new()
        {
            new EventModel { Name = "Corporate Gala", Date = new DateTime(2025, 8, 15), Location = "London" },
            new EventModel { Name = "Team Retreat", Date = new DateTime(2025, 9, 10), Location = "Bath" },
            new EventModel { Name = "Product Launch", Date = new DateTime(2025, 10, 1), Location = "Manchester" }
        };

        public List<EventModel> GetEvents() => _events;

        public void AddEvent(EventModel ev)
        {
            _events.Add(ev);
        }
    }
}