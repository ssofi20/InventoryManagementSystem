using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Domain
{
    internal class Image
    {
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
