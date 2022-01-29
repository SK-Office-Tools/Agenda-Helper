using System;
using System.Collections.Generic;

namespace AgendaHelper.Models
{
    public record AgendaItem
    {
        public AgendaItem()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; init; }
        public int Order { get; set; }
        public DateTime Start { get; set; }
        public int Duration { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Presenters { get; set; }
        public IEnumerable<string> Links { get; set; }
    }
}
