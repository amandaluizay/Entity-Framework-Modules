using System;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog {
    class program{
        static void Main(string[] args){
            using var context= new BlogDataContext();

            /* var user = new User{
                Name="amanda",
                Slug="amandaluiza",
                Email= "amanda@luiza",
                Bio = "estudante",
                Image = "https",
                PasswordHash="55466"
            };

            var category = new Category{
                Name = "backend",
                Slug = "back"
            };

            var post = new Post
             {
                Author = user,
                Category = category,
                Body = "<p>Hello world</p>",
                Slug = "comecando-com-ef-core",
                Summary = "Neste artigo vamos aprender EF core",
                Title = "Começando com EF Core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
             };

             context.Posts.Add(post);
             context.SaveChanges(); */

             /*var posts = context
                .Posts
                .AsNoTracking()
                .Include(x=> x.Author)
                .Where(x=> x.AuthorId == 3)
                .OrderByDescending(x=>x.LastUpdateDate)
                .ToList();

            foreach(var post in posts){
                Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");
            } */

            var post = context
            .Posts
            .Include(x=>x.Author)
            .Include(x=>x.Category)
            .OrderBy(x=>x.LastUpdateDate)
            .FirstOrDefault();

            post.Author.Name = "Teste";
            context.SaveChanges();

        }
    }
}