using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationRazorPagesDemo.Models;

namespace WebApplicationRazorPagesDemo.Pages
{
    public class EmployeeModel : PageModel
    {

        [BindProperty]
        public Employee Emps { get; set; } = new Employee();
        public void OnGet()
        {
            //This method will be called when the page is loaded
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ViewData["Message"] = $"Hello {Emps.Name}";
            return Page();
        }
    }
}
