using System;
using System.Collections.Generic;
using Blog.Core.Models;

namespace Blog.DataAccess
{
    /// <summary>
    /// Initializer block for our Blog
    /// </summary>
    public class BlogInitializer : System.Data.Entity.DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            // create
            var articles = new List<Article>
            {
                new Article
                {
                    Name = "Article 1", Date = DateTime.Parse("2019-09-19"),
                    Text =
                        "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Autem voluptate aspernatur incidunt maxime beatae deleniti exercitationem repellat, adipisci tempora repellendus doloremque ratione, laboriosam hic dolores ipsa asperiores illo reiciendis similique ut, eos itaque quasi tempore excepturi? Magnam esse voluptatibus dolor."
                },
                new Article
                {
                    Name = "Article 2", Date = DateTime.Parse("2019-09-19"),
                    Text =
                        "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Autem voluptate aspernatur incidunt maxime beatae deleniti exercitationem repellat, adipisci tempora repellendus doloremque ratione, laboriosam hic dolores ipsa asperiores illo reiciendis similique ut, eos itaque quasi tempore excepturi? Magnam esse voluptatibus dolor."
                },
                new Article
                {
                    Name = "Article 3", Date = DateTime.Parse("2019-09-19"),
                    Text =
                        "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Autem voluptate aspernatur incidunt maxime beatae deleniti exercitationem repellat, adipisci tempora repellendus doloremque ratione, laboriosam hic dolores ipsa asperiores illo reiciendis similique ut, eos itaque quasi tempore excepturi? Magnam esse voluptatibus dolor."
                },
                new Article
                {
                    Name = "Article 4", Date = DateTime.Parse("2019-09-19"),
                    Text =
                        "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Autem voluptate aspernatur incidunt maxime beatae deleniti exercitationem repellat, adipisci tempora repellendus doloremque ratione, laboriosam hic dolores ipsa asperiores illo reiciendis similique ut, eos itaque quasi tempore excepturi? Magnam esse voluptatibus dolor."
                }
            };
            // and add entity
            articles.ForEach(s => context.Articles.Add(s));
            context.SaveChanges();
            var feedbackItems = new List<Feedback>
            {
                new Feedback
                {
                    Author = "Author 1", Date = DateTime.Parse("2019-09-19"),
                    Text =
                        "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit in animi, quisquam vel non placeat minus numquam accusamus voluptatibus atque."
                },
                new Feedback
                {
                    Author = "Author 2", Date = DateTime.Parse("2019-09-19"),
                    Text =
                        "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit in animi, quisquam vel non placeat minus numquam accusamus voluptatibus atque."
                },
                new Feedback
                {
                    Author = "Author 3", Date = DateTime.Parse("2019-09-19"),
                    Text =
                        "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit in animi, quisquam vel non placeat minus numquam accusamus voluptatibus atque."
                },
                new Feedback
                {
                    Author = "Author 4", Date = DateTime.Parse("2019-09-19"),
                    Text =
                        "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit in animi, quisquam vel non placeat minus numquam accusamus voluptatibus atque."
                },
            };
            feedbackItems.ForEach(s => context.FeedbackItems.Add(s));
            context.SaveChanges();



            Profile profile = new Profile
            {
                ProfilePreview = "На сколько вы человек?",

                Results = new Dictionary<int, string>()
                {
                    {1,"Ты человек, но не понятно мужчина или женщина."},
                    {2, "Ты мужчинка, но не человек." },
                    {3,"Ты человеко-мужчина, всё решено." },
                    {4, "Ты человеко-женщина." },
                    {5,"Ты мужчино-женщина, но не человек(оно и понятно)." },
                    {6,"Ты не умеешь отвечать в анкетировании." }
                },
                Questions = new List<Question>
                {
                    new Question
                    {
                        Text = "Ты человек?",
                        Variants = new List<Variant>
                        {
                            new Variant{Id = 1,Text = "Да", Value = false},
                            new Variant{Id = 2,Text = "Нет", Value = false},
                            new Variant{Id=3,Text = "Не знаю", Value = false}
                        }
                    },
                    new Question
                    {
                        Text = "Ты мужчина?",
                        Variants = new List<Variant>
                        {
                            new Variant{Id = 1,Text = "Да", Value = false},
                            new Variant{Id = 2,Text = "Нет", Value = false},
                            new Variant{Id=3,Text = "Не знаю", Value = false}
                        }
                    },
                    new Question
                    {
                        Text = "Ты женщина?",
                        Variants = new List<Variant>
                        {
                            new Variant{Id = 1,Text = "Да", Value = false},
                            new Variant{Id = 2,Text = "Нет", Value = false},
                            new Variant{Id=3,Text = "Не знаю", Value = false}
                        }
                    }
                }

            };

            context.Profiles.Add(profile);
            context.SaveChanges();
        }
    }
}