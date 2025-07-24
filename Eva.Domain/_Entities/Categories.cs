using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva.Domain._Entities
{
    public class Categories
    {
        public int CategoryId { get; set; }
   //     [DataType("varchar(50)")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int CategoryOrder { get; set; }
        public bool IsDeleted { get; set; }

    }
}
