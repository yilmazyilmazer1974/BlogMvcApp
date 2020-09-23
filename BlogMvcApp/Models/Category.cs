using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public virtual List<Blog>Bloglar { get; set; }

    }
}