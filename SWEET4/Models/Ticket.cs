using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWEET4.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }
        public Boolean Closed { get; set; }
    }
}