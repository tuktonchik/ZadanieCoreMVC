using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Localization;

namespace ZadanieCoreMVC.Models
{
    public class UserViewModel
    {
        [Display(ResourceType = typeof(App_GlobalResources.GlobalResource), Name = "NickName")]
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.GlobalResource), ErrorMessageResourceName = "NickName_Is_Required", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]{1,30}$", ErrorMessageResourceType = typeof(App_GlobalResources.GlobalResource), ErrorMessageResourceName = "NickName_Is_Required")]
        public string NickName { get; set; }

        [Display(ResourceType = typeof(App_GlobalResources.GlobalResource), Name = "Email")]
        [Required(ErrorMessageResourceType = typeof(App_GlobalResources.GlobalResource), ErrorMessageResourceName = "Email_Is_Required", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessageResourceType = typeof(App_GlobalResources.GlobalResource), ErrorMessageResourceName = "Email_Format_Is_Incorrect")]
        public string Email { get; set; }
    }
}
