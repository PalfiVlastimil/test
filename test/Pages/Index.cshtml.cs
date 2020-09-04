using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using test.Model;
using test.Services;

namespace test.Pages
{
    public class IndexModel : PageModel
    {
        public User AUser { get; set; }
        private readonly SessionStorage<User> _st;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(SessionStorage<User> st)
        {
            _st = st;
            
        }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            
        }
    }
}
