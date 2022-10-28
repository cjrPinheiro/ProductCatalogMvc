using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductCatalogMvc.WebUI.Views.Home
{
    public class CategoryModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Yaloaloaloa";
        }
    }
}
