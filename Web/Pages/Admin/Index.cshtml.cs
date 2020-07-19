using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web.Data;
using Web.Data.Models;

namespace Web.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageBlogContext _context;

        public IndexModel(RazorPageBlogContext context)
        {
            _context = context;
        }

        public IList<Article> Articles { get; set; }


        public async Task OnGetAsync()
        {
            Articles = await _context.Article.ToListAsync();
        }
    }
}