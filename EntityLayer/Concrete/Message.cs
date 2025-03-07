using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public int Name { get; set; }
        public int Mail { get; set; }
        public int Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status{ get; set; }
    }
}
