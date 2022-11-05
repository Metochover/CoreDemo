using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        //Erişim Belirteci Değişken Türü İsim {get set}
        [Key]

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; } //İlişkili tablolarda kategori silme işlemi sıkıntı olduğundan aktif ya da pasif işlemi için kullanıcağımız depişken

        public List<Blog> Blogs { get; set; }
    }
}
