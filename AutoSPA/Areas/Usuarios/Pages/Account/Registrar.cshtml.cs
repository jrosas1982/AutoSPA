using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoSPA.Areas.Usuarios.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoSPA.Areas.Usuarios.Pages.Account
{
    public class RegistrarModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel : InputModelRegistrar 
        { 
         public IFormFile AvatarImage { get; set; }
        }

    }
}
