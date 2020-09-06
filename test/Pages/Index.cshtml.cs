using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using test.Helpers;
using test.Model;
using test.Services;

namespace test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SessionStorage<User> _log;
        public User Login { get; set; }
        public IndexModel(SessionStorage<User> log)
        {
            _log = log;
            
        }

        public void OnGet()
        {
            
            

        }
        public void OnPost()
        {
            _log.Store();
            Login = _log.Logger;
        }
    }
}
