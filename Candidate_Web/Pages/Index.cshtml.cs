using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BussinessObject;
using CandidateService.IService;

namespace Candidate_Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BussinessObject.CandidateManagementContext _context;
        private readonly IHRAccountService hRAccountService;

        public IndexModel(IHRAccountService hRAccountService)
        {
            this.hRAccountService = hRAccountService;
        }

        public IList<CandidateProfile> CandidateProfile { get;set; }

        public async Task OnGetAsync(int pageNumber = 1, int pageSize = 3)
        {
            var userRole = int.Parse(HttpContext.Session.GetString("UserRole"));

            if(userRole == 2)
            {
                CandidateProfile = hRAccountService.GetCandidateProfiles();
            }
            else
            {
                TempData["message"] = "You do have permission to do this features!";
                RedirectToPage("/Login");
            }
        }
    }
}
