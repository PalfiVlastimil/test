using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Model;

namespace test.Services
{
    public interface ISessionStorage<T>
    {
        public void Save(string key, User data);
        public void Store();
        
    }
}
