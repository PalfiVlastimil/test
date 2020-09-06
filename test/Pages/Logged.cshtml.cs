using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using test.Model;
using test.Services;

namespace test.Pages
{
    public class LoggedModel : PageModel
    {
        private readonly SessionStorage<User> _log;
        public User Login { get; set; }
        
        public LoggedModel(SessionStorage<User> log)
        {
            _log = log;

        }
        public void OnGet()
        {
            _log.Store();
            Login = _log.Logger;
            
        }
    }
}
