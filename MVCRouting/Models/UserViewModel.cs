namespace MVCRouting.Models
{
    using System.Collections.Generic;

    public class UserViewModel
    {
        public UserViewModel()
        {
            Views = new List<string>();
        }

        public string Name { get; set; }
        public string Password { get; set; }

        public List<string> Views { get; set; }
    }
}