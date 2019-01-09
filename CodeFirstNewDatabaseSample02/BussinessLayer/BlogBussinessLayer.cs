﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models;
using ConsoleApplication1.DataAccessLayer;
using System.Data.Entity;

namespace ConsoleApplication1.BussinessLayer
{
    public class BlogBussinessLayer
    {
        public void Add(Blog blog)
        {
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(blog);
               // db.Entry(Blog).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public List<Blog> Query()
        {
            using (var db = new BloggingContext())
            {
                return db.Blogs.ToList();
            }
        }
        public Blog Query(int id) {

            using (var db = new BloggingContext())
            {
                return db.Blogs.Find(id);
            }
        }


        public void Update(Blog blog) {

            using (var db = new BloggingContext())
            {
                db.Entry(blog).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(Blog blog)
        {

            using (var db = new BloggingContext())
            {
               db.Entry(blog).State = EntityState.Deleted;
               // db.Blogs.Remove(blog);
                db.SaveChanges();
            }
        }

        public List<Blog> Query(string name)
        {
            using (var db = new BloggingContext())
            {
                // 查询所有包含字符串name的博客
                var blogs = from b in db.Blogs
                            where b.Name.Contains(name)
                            select b;
                return blogs.ToList();
            }
        }

    }
}
