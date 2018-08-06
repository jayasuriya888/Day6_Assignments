using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Day6_Assignment_02_23_07_2018
{
    class CodeDBEntities:DbContext
    {
        public DbSet<PizzaDetail> PizzaDetails { get; set; }

        public CodeDBEntities():base("MyDBPizza")
        {

        }
    }
}
