using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LMS.WebAPI.Models
{
    public class LMSWebAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public LMSWebAPIContext() : base("name=LMSWebAPIContext")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public System.Data.Entity.DbSet<LMS.WebAPI.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<LMS.WebAPI.Models.Student> Students { get; set; }
        public System.Data.Entity.DbSet<LMS.WebAPI.Models.Enrollment> Enrollments { get; set; }
    }
}
