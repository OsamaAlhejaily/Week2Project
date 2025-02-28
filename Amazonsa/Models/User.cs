using System.Collections.Generic;

namespace amazonsa.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
    }
}
