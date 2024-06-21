using System;
using System.Collections.Generic;

namespace CRUDTEST.Models
{
    public partial class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public DateOnly? Register { get; set; }
    }
}
