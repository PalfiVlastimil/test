using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Services
{
    public class SessionStorage<User>
    {
        readonly ISession _session;
        const string KEY = "VERYSECRET";
        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
            

        }
    }
}
