using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    class Message
    {
        public DateTime SendDate { get; set; }
        public string Content { get; set; }       
        public User User { get; set; }
        public Message()
        {
            SendDate = DateTime.Today;
        }

    }
}
