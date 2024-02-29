using KodlamaioDemo.Business.Concretes;
using KodlamaioDemo.DataAccess.Concretes;
using KodlamaioDemo.Entites;

Category category1 = new Category();
category1.Id = 1;
category1.Name = "Back End";

Category category2 = new Category();
category2.Id = 2;
category2.Name = "Front End";

CategoryManager categoryManager = new CategoryManager(new CategoryDal());
categoryManager.Add(category1);
categoryManager.Add(category2);

categoryManager.Delete(category2);

List<Category> categories = categoryManager.GetAll();

foreach (var category in categories)
{
    Console.WriteLine(category.Name);
}


Console.WriteLine();

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = "C# + Angular";
course1.Price = 0;
course1.ProgressBar = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java";
course2.Description = "Java + React";
course2.Price = 0;
course1.ProgressBar = 0;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python & Selenium";
course3.Description = "Yazılım geliştirici yetiştirme kampı";
course3.Price = 0;
course3.ProgressBar = 25;



CourseManager courseManager = new CourseManager(new CourseDal());
courseManager.Add(course1);
courseManager.Add(course2);
courseManager.Add(course3);

List<Course> courses = courseManager.GetAll();

foreach (var course in courses)
{
    Console.WriteLine(course.Name + " : " + course.Description + " : " + course.ProgressBar);
}

Console.WriteLine();


Course updateCourse1 = new Course();
updateCourse1.Id = 1;
updateCourse1.Name = "C#";
updateCourse1.Description = "Sıfırdan profesyonelliğe";
updateCourse1.Price = 0;
updateCourse1.ProgressBar = 100;


courseManager.Update(updateCourse1);

foreach (var course in courses)
{
    Console.WriteLine(course.Name + " : " + course.Description + " : " + course.ProgressBar);
}



