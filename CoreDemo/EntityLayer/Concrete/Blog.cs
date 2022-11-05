using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }//içerik
        public string BlogThumbnailImage { get; set; } // küçük resim
        public string BlogImage { get; set; } // büyük resim
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
