namespace LMS.WebAPI.Migrations
{
    using LMS.WebAPI.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LMS.WebAPI.Models.LMSWebAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LMS.WebAPI.Models.LMSWebAPIContext context)
        {     
            context.Courses.AddOrUpdate(x => x.CourseID,
             new Course() { CourseID = 001, Title = "Github Webhooks for Beginners", Duration=2,Description="sample",Image="abc.jpg" },
             new Course() { CourseID = 002, Title = "Awesome CSS with LESS Processing", Duration = 2, Description = "sample", Image = "abc.jpg" },
             new Course() { CourseID = 003, Title = "Vagrant Portable Environments", Duration = 2, Description = "sample", Image = "abc.jpg" }
            
        );

            context.Students.AddOrUpdate(x => x.ID,
                new Student()
                {
                    ID= 1,
                    FirstMidName="Usman",
                    LastName= "Sheikh",
                    EnrollmentDate= DateTime.Now
                },
                 new Student()
                {
                    ID= 2,
                    FirstMidName="Bilal",
                    LastName= "Saeed",
                    EnrollmentDate= DateTime.Now
                }
                
                );
        }
    }
}
