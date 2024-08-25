using EmailTestWebApp.Models;
using EmailTestWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmailTestWebApp.Pages
{
    public class WebtestModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = SendEmail.Send(Email);


                }
                else
                {
                    ViewData["ErrorMessage"] = "Validation Errorl";
                }
            }
            catch (System.Exception ex)
            {

                ViewData["ErrorMessage"] = ex.Message;
            }


            return Page();
        }

        #region  Properties
        [BindProperty]
        public Email Email { get; set; }
        #endregion
    }
}
