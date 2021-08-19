using System.Collections.Generic;

namespace Store.Web.Models
{
    public class Cart
    {
        public int OrderId { get; }

        public int TotalCount { get; set; }
    }
}
