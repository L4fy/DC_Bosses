using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Comments
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public DateTime Date { get; set; }
        public int UsersId { get; set; }
        public Users? Users { get; set; }
    }
}