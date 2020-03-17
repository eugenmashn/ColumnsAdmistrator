using System;
using System.Collections.Generic;
using System.Text;

namespace Date.Models
{
  public  class Sittings
    {
        public Guid Id { get;set; }
        public bool ShowDescr { get; set; }
        public bool ShowIsInStock { get; set; }
        public bool ShowAttachment { get; set; }
    }
}
