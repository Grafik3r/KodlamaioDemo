using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> _courses;
    public CourseDal()
    {
        _courses = new List<Course>();
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
    }


    public List<Course> GetAll()
    {
        return _courses;
    }

    public void Update(Course course)
    {
        Course existCourse = _courses.Find(x => x.Id == course.Id);
        if (existCourse is null)
            return;
        existCourse.Name = course.Name;
        existCourse.Description = course.Description;
        existCourse.CategoryId = course.CategoryId;
        existCourse.InstructorId = course.InstructorId;
        existCourse.Image = course.Image;
        existCourse.Price = course.Price;
        existCourse.ProgressBar = course.ProgressBar;
    }


}
