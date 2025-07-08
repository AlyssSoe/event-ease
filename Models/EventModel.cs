using System;
using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventModel
    {
        [Required(ErrorMessage = "Event name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Event date is required")]
        public DateTime Date { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Event location is required")]
        public string Location { get; set; }
    }
}