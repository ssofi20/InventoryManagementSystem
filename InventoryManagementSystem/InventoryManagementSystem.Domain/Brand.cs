using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Domain
{
    internal class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
