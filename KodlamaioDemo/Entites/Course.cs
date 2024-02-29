using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Entites;

public class Course
{
    public int Id { get; set; }
    public int CategoryId{ get; set; }
    public int InstructorId { get; set; }   
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Image { get; set; }
    public int ProgressBar { get; set; }

}
