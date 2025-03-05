using Program.DbContexts;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;
using Program.Modules;
using Microsoft.EntityFrameworkCore;

namespace Program
{
    internal class Program
    {
        static void Main()
        {
            using ITIDbContext dbcontext = new ITIDbContext();

            //Insert, Select, Update, Delete

            //Insert Into Topic & Course

            //List<Topic> topics = new List<Topic>()
            //{
            //    new Topic() { Name = "Top01" },
            //    new Topic() { Name = "Top02" },
            //    new Topic() { Name = "Top03" },
            //    new Topic() { Name = "Top04" },
            //};


            //dbcontext.Set<Topic>().AddRange(topics);
            //dbcontext.SaveChanges();

            //List<Course> courses = new ()
            //{
            //    new Course(){ Name = "Course01" , Duration = 215 , TopId = 1 },
            //    new Course(){ Name = "Course02" , Duration = 215 , TopId = 2 },
            //    new Course(){ Name = "Course03" , Duration = 215 , TopId = 3 },
            //};

            //dbcontext.Set<Course>().AddRange(courses);
            //dbcontext.SaveChanges();

            //Select From Courses
            //var selectedCourse = dbcontext.Set<Course>().FirstOrDefault(C => C.Id == 1);
            //Console.WriteLine($"{selectedCourse?.Id} ---------- {selectedCourse?.Name}");

            //Update Topics
            //if (selectedTopic is not null)
            //    selectedTopic.Name = "UpdatedName";
            //dbcontext.SaveChanges();

            //Delete from Topics
            //if (selectedTopic is not null)
            //    dbcontext.Remove(selectedTopic);
            //dbcontext.SaveChanges();

            //eager loading
            //var result = dbcontext.Set<Course>().Include(C => C.Topic);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"course Id ={item.Id}, Topic :{item.Topic.Name}");
            //}

            //Lazy loading
            var result = dbcontext.Set<Course>().ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"course Id ={item.Id}, Topic :{item.Topic.Name}");
            }
        }
    }
}
