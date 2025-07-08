using EventEase.Models;
using System.Collections.Generic;
using System.Linq;

namespace EventEase.Services
{
    public class UserSessionService
    {
        public List<EventModel> CreatedEvents { get; private set; } = new();
        public List<AttendanceRecord> Attendance { get; private set; } = new();

        public void AddCreatedEvent(EventModel ev)
        {
            CreatedEvents.Add(ev);
        }

        public void AddRegistration(AttendanceRecord record)
        {
            Attendance.Add(record);
        }

        public List<AttendanceRecord> GetRegistrationsForEvent(string eventName)
        {
            return Attendance
                .Where(r => r.EventName.Equals(eventName, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
