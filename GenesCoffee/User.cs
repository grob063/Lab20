using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab20EFCore.GenesCoffee
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
