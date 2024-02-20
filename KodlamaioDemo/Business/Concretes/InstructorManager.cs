using KodlamaioDemo.Business.Abstracts;
using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business.Concretes
{
    public class InstructorManager:IInstructorManager
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor ınstructor)
        {
            _instructorDal.Add(ınstructor);
        }
        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        
    }
}
