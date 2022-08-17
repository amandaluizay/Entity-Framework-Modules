using System;
using Blog.Data;
using Blog.Models;

namespace Blog {
    class program{
        static void Main(string[] args){
            using(var context= new BlogDataContext()){
                
                //create
                /* var tag = new Tag {Name="ASP.NET", Slug="aspnet"};
                context.Tags.Add(tag);
                context.SaveChanges(); */

               // Delete
                /* var tag = context.Tags.FirstOrDefault(x=> x.Id == 1);
                context.Remove(tag);
                context.SaveChanges(); */

                var tags = context.Tags.ToList();

                foreach (var tag in tags)
                {
                    Console.WriteLine(tag.Name);
                }
            }

        }
    }
}