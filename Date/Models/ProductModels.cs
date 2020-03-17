using System;
using System.Collections.Generic;
using System.Text;

namespace Date.Models
{
    public  class ProductModels
    {
        
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set;}
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public bool IsInStock { get; set; }
        public byte[] File { get; set; }
    }
}
