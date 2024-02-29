using KodlamaioDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business.Abstracts;

public interface IInstructorService
{
    void Add(Instructor instructor);
    void Delete(Instructor instructor);
    void Update(Instructor instructor);
    List<Instructor> GetAll();

}
