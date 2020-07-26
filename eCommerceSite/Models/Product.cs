using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace eCommerceSite.Models
{
    /// <summary>
    /// A salable product.
    /// </summary>
    public class Product
    {
        [Key] // Makes sure that this property is a primary key
        public int ProductId { get; set; }
        /// <summary>
        /// The consumer facing name of the product.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The retail price as US currency.
        /// </summary>
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        /// <summary>
        /// Category product falls under. Ex: Gadgets or Furnature
        /// </summary>
        public string Category { get; set; }
    }
}
