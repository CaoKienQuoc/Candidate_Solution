using BussinessObject;
using CandidateRepository.IRepository;
using CandidateService.IService;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Candidate_Web.Pages
{
    public class LoginModel : PageModel
    {
        private IHRAccountService hrAccountService;
       
        [BindProperty]
        public string Email {  get; set; }
        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {

        }

        public LoginModel(IHRAccountService hrAccountService)
        {
            this.hrAccountService = hrAccountService;
        }

        public IActionResult OnPost()
        {
            var user = hrAccountService.GetHraccountByEmail(Email);

            if (user != null && user.Password.Equals(Password))
            {
                HttpContext.Session.SetString("UserRole", user.MemberRole.ToString());
                
                if (user.MemberRole == 2)
                {
                   return RedirectToPage("/Index");
                }
                else
                {
                    TempData["message"] = "You are not allowed to do this function!";
                    return RedirectToPage();
                }
            }
            else
            {
                TempData["message"] = "Incorrect Email or Password";
                return RedirectToPage();
            }
        }
    }
}
