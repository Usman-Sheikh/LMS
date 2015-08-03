using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.WebAPI.Models
{
    public class StudentRepository
    {
        private LMSWebAPIContext db = new LMSWebAPIContext();
        /// <summary>
        /// Creates a new product with default values
        /// </summary>
        /// <returns></returns>
        internal Student Create()
        {
            Student student = new Student
            {
                EnrollmentDate = DateTime.Now
            };
            return student;
        }

        /// <summary>
        /// Retrieves the list of products.
        /// </summary>
        /// <returns></returns>
        //internal List<Student> Retrieve()
        //{

        //    var students = db.Students;






        //    return students;
        //}

        ///// <summary>
        ///// Saves a new product.
        ///// </summary>
        ///// <param name="product"></param>
        ///// <returns></returns>
        //internal Product Save(Product product)
        //{
        //    // Read in the existing products
        //    var products = this.Retrieve();

        //    // Assign a new Id
        //    var maxId = products.Max(p => p.ProductId);
        //    product.ProductId = maxId + 1;
        //    products.Add(product);

        //    WriteData(products);
        //    return product;
        //}

        ///// <summary>
        ///// Updates an existing product
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="product"></param>
        ///// <returns></returns>
        //internal Product Save(int id, Product product)
        //{
        //    // Read in the existing products
        //    var products = this.Retrieve();

        //    // Locate and replace the item
        //    var itemIndex = products.FindIndex(p => p.ProductId == product.ProductId);
        //    if (itemIndex > 0)
        //    {
        //        products[itemIndex] = product;
        //    }
        //    else
        //    {
        //        return null;
        //    }

        //    WriteData(products);
        //    return product;
        //}


        //private bool WriteData(List<Product> products)
        //{
        //    // Write out the Json
        //    var filePath = HostingEnvironment.MapPath(@"~/App_Data/product.json");

        //    var json = JsonConvert.SerializeObject(products, Formatting.Indented);
        //    System.IO.File.WriteAllText(filePath, json);

        //    return true;
        //}

    }
}