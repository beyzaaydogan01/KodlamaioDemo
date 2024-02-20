using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business.Abstracts
{
    public interface IGenericManager<T>
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetAll();
    }
}
