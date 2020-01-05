using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW9.Models
{
    public class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
