using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BussinessObject;
using System.Runtime.CompilerServices;
using CandidateService.IService;

namespace Candidate_Web.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly IHRAccountService HRAccountService;

        public IndexModel(IHRAccountService accountService)
        {
            HRAccountService = accountService;
        }

        public IList<Hraccount> Hraccount { get; set; }

        public async Task OnGetAsync()
        {
            var userRole = int.Parse(HttpContext.Session.GetString("UserRole"));

            if(userRole == 1 || userRole == 2)
            {
                if (HRAccountService.GetHraccounts() != null)
                {
                    Hraccount = HRAccountService.GetHraccounts();
                }
            }
            else
            {
                TempData["message"] = "You do have permission to do this features!";
                RedirectToPage("./Login");
            }
            
        }
    }
}
