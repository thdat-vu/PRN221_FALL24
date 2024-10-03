using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Candidate_BusinessObjects.Models;
using Candidate_Daos;

namespace CandidateRazorWeb.Pages.JobPostingPage
{
    public class CreateModel : PageModel
    {
        private readonly Candidate_Daos.CandidateManagementContext _context;

        public CreateModel(Candidate_Daos.CandidateManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JobPosting JobPosting { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.JobPostings == null || JobPosting == null)
            {
                return Page();
            }

            _context.JobPostings.Add(JobPosting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
