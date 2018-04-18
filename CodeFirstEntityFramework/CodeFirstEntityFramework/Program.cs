﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { BlogName = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Blogs
                            orderby b.BlogName
                            select b;
                var query2 = db.Blogs
                    .Where(a => true)
                    .OrderByDescending(a => a.BlogName);

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query2)
                {
                    Console.WriteLine(item.BlogName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

        }

    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }

        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }

    }

    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
