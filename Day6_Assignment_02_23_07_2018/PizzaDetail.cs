using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Day6_Assignment_02_23_07_2018
{
    class PizzaDetail
    {
        [Key]
        public int PizzaId { get; set; }
        [Required]
        public string PizzaName { get; set; }
        [Required]
        public string PizzaToppings { get; set; }
        [Required]
        public string PizzaType { get; set; }
        [Required]
        
        public char PizzaSize { get; set; }
        [Required]
        public int PizzaPrice { get; set; }
                
    }
}
