using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models;
using ConsoleApplication1.DataAccessLayer;
using System.Data.Entity;

namespace ConsoleApplication1.BussinessLayer
{
  public  class PostBussinessLayer
    {
        public List<Post> Query(int blogId)
        {
            using (var db=new BloggingContext())
            {
                var Query = from b in db.Posts
                            where b.BlogId == blogId
                            select b;
                return Query.ToList();
            }
        }
        public void Add(Post post)
        {
            using (var db=new BloggingContext())
            {
                db.Entry(post).State = EntityState.Added;
                db.SaveChanges();
            }
        }
        public Post QueryPost(int id)
        {
            using (var db=new BloggingContext())
            {
                return db.Posts.Find(id);
            }
        }
        public void Update(Post post)
        {

            using (var db = new BloggingContext())
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void DeletePost(Post post)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(post).State = EntityState.Deleted;

                db.SaveChanges();
            }
        }

        //public List<Post> QueryForTitle(string title)
        //{
        //    using(var db=new BloggingContext())
        //    {
        //        var query = db.Posts.Where(x => x.Title == title);
        //    }
        //    return query.ToList();
        //}
    }
}
