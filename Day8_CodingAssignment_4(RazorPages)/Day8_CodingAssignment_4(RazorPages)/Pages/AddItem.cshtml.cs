using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Day8_CodingAssignment_4_RazorPages_.Pages
{
    public class AddItemModel : PageModel
    {
        [BindProperty]
        public string? NewItem { get; set; }

        public void OnGet()
        {
           
        }

        public IActionResult OnPost()
        {
            
            if (!string.IsNullOrWhiteSpace(NewItem))
            {
                ItemsStore.Items.Add(NewItem);
            }

            
            return RedirectToPage("Items");
        }
    }
}
