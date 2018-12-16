using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Model
{
   public class Sale
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int count { get; set; }
        public int sum { get; set; }
        public Book Book { get; set; }

    }
}
