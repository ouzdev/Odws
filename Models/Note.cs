using System;
using System.Collections.Generic;

namespace Odws.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
    }
}
