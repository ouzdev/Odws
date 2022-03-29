using System;
using System.Collections.Generic;

namespace Odws.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
