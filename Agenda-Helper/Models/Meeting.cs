using System;
using System.Collections.Generic;

namespace AgendaHelper.Models
{
    public record Meeting
    {
        public Meeting()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; init; }
        public DateTime Start { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Chair { get; set; }
        public IEnumerable<string> Secretariat { get; set; }
        public IEnumerable<AgendaItem> Agenda { get; set; }
    }
}
