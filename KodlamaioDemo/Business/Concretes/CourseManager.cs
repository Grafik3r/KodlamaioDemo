﻿using KodlamaioDemo.Business.Abstracts;
using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.DataAccess.Concretes;
using KodlamaioDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business.Concretes;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}
