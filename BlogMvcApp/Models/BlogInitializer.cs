using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : CreateDatabaseIfNotExists<BlogCentext>
    {
        protected override void Seed(BlogCentext context)
        {
            //Burada Veritabanına Test verileri Ekliyoruz.

            List<Category> kategoriler = new List<Category>()
            {
                new Category() {KategoriAdi="C#"},
                new Category() {KategoriAdi="Asp.Net MVC"},
                new Category() {KategoriAdi="Asp.Net Web Form"},
                new Category() {KategoriAdi="Windows Form"},
            };

            //Yukarıdaki Kategorileri Context'in içerisine foreach ile ekliyoruz. Yani Veritabanına ekliyoruz.

            foreach (Category category in kategoriler)
            {
                //context.Kategoriler.Add(new Category()
                //{
                //    KategoriAdi = category.KategoriAdi,
                //}); 

                context.Kategoriler.Add(category);
            }
            context.SaveChanges();
            //Burada Blogları Ekliyoruz.

            List<Blog> bloglar = new List<Blog>()
            {

                new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),AnaSayfa=false,Onay=false, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="1.jpg", CategoryId=1},


                  new Blog(){Baslik="C# Delegates", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),AnaSayfa=false,Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="1.jpg", CategoryId=1},

                  new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-30),AnaSayfa=true,Onay=false, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="1.jpg", CategoryId=1},

                  new Blog(){Baslik="C# Generic List Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-20),AnaSayfa=true,Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="2.jpg", CategoryId=2},

                  new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-5),AnaSayfa=true,Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="2.jpg", CategoryId=2},

                  new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),AnaSayfa=true,Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="2.jpg", CategoryId=2},

                  new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),AnaSayfa=true,Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="1.jpg", CategoryId=3},
                 
                  new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),AnaSayfa=true,Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="2.jpg", CategoryId=3},

                  new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-15),AnaSayfa=true,Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="1.jpg", CategoryId=3},

                  new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-20),AnaSayfa=false,Onay=false, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="2.jpg", CategoryId=4},

                  new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),AnaSayfa=true,Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="1.jpg", CategoryId=4},

                  new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),AnaSayfa=true,Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="2.jpg", CategoryId=4},

                  new Blog(){Baslik="C# Delegates Hakkında", Aciklama="C# Delegates Hakkında C# Delegates Hakkında",EklemeTarihi=DateTime.Now.AddDays(-10),AnaSayfa=true,Onay=true, Icerik="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında", Resim="1.jpg", CategoryId=4},

            };

            // Blog Listesine Eklenen öğeleri de list Context Aracılığı ile Veritabanına yazdırıyoruz.

            foreach (Blog blog in bloglar)
            {
                context.Bloglar.Add(blog);
            }

            context.SaveChanges();



            
        }
    }
}