using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JunaidAlam.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product Name Is Required")]
        public string P_Name { get; set; }

        [DisplayName("Product Description")]
        public string P_Des { get; set; }


        [DisplayName("Product Code")]
        [Required(ErrorMessage = "Product Code Is Required")]
        public string P_Code { get; set; }


        [DisplayName("Product Image")]
        [Required(ErrorMessage = "Product Image Is Required")]
        public string P_Img { get; set; }


        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Product Price Is Required")]
       [DataType(DataType.Currency)]
        public int P_Price { get; set; }


        [DisplayName("Product Category")]
        [Required(ErrorMessage = "Product Category Is Required")]
        public string P_Catg { get; set; }
    }
}
