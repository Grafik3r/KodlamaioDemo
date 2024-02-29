using KodlamaioDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business.Abstracts;

public interface ICategoryService
{
    void Add(Category catogory);
    void Delete(Category category);
    void Update(Category category);
    List<Category> GetAll();

}
