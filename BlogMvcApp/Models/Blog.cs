using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace BlogMvcApp.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string   Resim { get; set; }
        public string Icerik { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool AnaSayfa { get; set; }

        //Burası Navigation Property'dir
        public  int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}