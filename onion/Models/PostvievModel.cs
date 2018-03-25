using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Onion.Web.Models
{
    public class PostVievModel
    {
        [HiddenInput]
        public Int32 Id { get; set; }
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Display(Name ="User Post")]
        public string UserPost { get; set; }
        [Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }

    }

    
}
