using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva.Domain._Entities
{
    public class Categories : BaseEntity
    {
   //     [DataType("varchar(50)")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int CategoryOrder { get; set; }

        public ICollection<Product> Products = new HashSet<Product>();

    }
}
