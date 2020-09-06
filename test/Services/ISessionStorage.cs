using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Services
{
    public interface ISessionStorage<T>
    {
        public void Save(string key, T data);
    }
}
