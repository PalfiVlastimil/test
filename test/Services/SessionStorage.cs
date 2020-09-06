using Microsoft.AspNetCore.Http;
using NPOI.OpenXmlFormats.Dml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Helpers;
using test.Model;

namespace test.Services
{
    public class SessionStorage<T>
    {
        readonly ISession _session;
        public User Logger { get; set; }
        const string KEY = "VERYSECRET";
        public SessionStorage(IHttpContextAccessor hca)
        {
            _session = hca.HttpContext.Session;
        }
        public void Save(string key, User data)
        {
            _session.Set(key, data);
        }
        
        public void Store()
        {
            Save(KEY, Logger);
        }
        
    }
}
