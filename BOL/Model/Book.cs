using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Model
{
   public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int  Price { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

    }
}
