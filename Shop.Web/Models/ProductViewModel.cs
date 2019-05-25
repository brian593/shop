

namespace Shop.Web.Models
{
    using Microsoft.AspNetCore.Http;
    using Shop.Web.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProductViewModel:Product
    {
        [Display(Name= "Image")]
        public IFormFile ImageFile { get; set; }

    }
}
