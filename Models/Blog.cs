using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace BlogNet.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [DisplayName("Years")]
        public string Time { get; set; }
        [DisplayName("Description")]
		[StringLength(500, MinimumLength = 60)]
        public string Content { get; set; }
        [DisplayName("URL of Logo")]
        public string Picture { get; set; }
    }
}
