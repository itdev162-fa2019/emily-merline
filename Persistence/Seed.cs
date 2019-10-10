using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First post!",
                        Date = DateTime.Now.AddDays(-10),
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus vel laoreet nunc."
                    },
                    new Post {
                        Title = "This is my second post.",
                        Date = DateTime.Now.AddDays(-7),
                        Body = "Vivamus varius nisi eleifend nunc lacinia, et sagittis mi ultricies. Suspendisse fermentum commodo neque eget fringilla"
                    },
                    new Post {
                        Title = "Another day, another post",
                        Date = DateTime.Now.AddDays(-4),
                        Body = "Duis egestas orci sagittis suscipit bibendum. Maecenas placerat vel tellus sed ornare."
                    }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}