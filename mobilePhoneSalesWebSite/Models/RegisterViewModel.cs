using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace mobilePhoneSalesWebSite.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "用户名")]
        public string Name { get; set; }

       /* [Required]
        [EmailAddress]
        [Display(Name = "手机号")]
        public string Phone { get; set; }*/


        [Required]
        [StringLength(20, ErrorMessage = "密码长度为6到20位", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "用户密码")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "重复密码")]
        [Compare("Password", ErrorMessage = "两次输入的密码不一致")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "邮箱")]
        public string Email { get; set; }
    }
}
