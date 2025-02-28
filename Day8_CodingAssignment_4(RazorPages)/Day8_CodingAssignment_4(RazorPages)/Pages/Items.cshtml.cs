using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Day8_CodingAssignment_4_RazorPages_.Pages
{
    public class ItemsModel : PageModel
    {
        public List<string> Items => ItemsStore.Items;

        public void OnGet()
        {
        }
    }
}
