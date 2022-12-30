using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace MvcFirstProject.Models
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            List<Category> Categories = new List<Category>()
            {
                new Category() { CategoryName="C#"},
                new Category() { CategoryName="Asp.Net MVC"},
                new Category() { CategoryName="Asp.Net WebForm"},
                new Category() { CategoryName="Windows Form"},
                new Category() { CategoryName="SQL"},
                new Category() { CategoryName="HTML"},
                new Category() { CategoryName="CSS"},
                new Category() { CategoryName="JavaScript"},
                new Category() { CategoryName="JQuery"}
            };
            foreach (var item in Categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();

            List<Blog> Blogs = new List<Blog>()
            {
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-10),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="1.jpg", CategoryId=1},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-13),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="3.jpg", CategoryId=3},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-1),HomePage=true,Statu=false,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="2.jpg", CategoryId=2},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-8),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="2.jpg", CategoryId=2},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-6),HomePage=false,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="4.jpg", CategoryId=4},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-4),HomePage=true,Statu=false,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="6.jpg", CategoryId=6},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-3),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="7.jpg", CategoryId=7},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-4),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="6.jpg", CategoryId=6},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-9),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="5.jpg", CategoryId=5},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-10),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="1.jpg", CategoryId=1},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-9),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="2.jpg", CategoryId=2},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-4),HomePage=true,Statu=false,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="3.jpg", CategoryId=3},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-1),HomePage=false,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="6.jpg", CategoryId=6},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-2),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="9.jpg", CategoryId=9},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-3),HomePage=true,Statu=false,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="8.jpg", CategoryId=8},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-7),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="5.jpg", CategoryId=5},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-12),HomePage=false,Statu=false,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="6.jpg", CategoryId=6},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-6),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="8.jpg", CategoryId=8},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-5),HomePage=true,Statu=true,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="7.jpg", CategoryId=7},
                new Blog(){ BlogName ="Yazılım Nedir?", Description="C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir.", Date=DateTime.Now.AddDays(-4),HomePage=true,Statu=false,Contents="C# İle Web Site Geliştirme, C# İle Masaüstü Windows Uygulamaları, C# Oyun Geliştirme",Image="4.jpg", CategoryId=4}
            };
            foreach (var item in Blogs)
            {
                context.Blogs.Add(item);
            }
            context.SaveChanges();
            base.Seed(context); 
        }
    }
}