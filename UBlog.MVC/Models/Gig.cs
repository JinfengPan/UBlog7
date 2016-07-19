using System;

namespace UBlog.MVC.Models
{
    /// <summary>
    /// 现场演唱会
    /// </summary>
    public class Gig
    {
        public int Id { get; set; }
        public ApplicationUser Artist { get; set; }
        public DateTime DateTime { get; set; }

        public string Venue { get; set; }

        public Genre Genre { get; set; }

    }
}