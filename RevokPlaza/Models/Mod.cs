using System;

namespace RevokPlaza.Models
{
    public class Mod
    {
        public int ModID { get; set; }
        public string Name { get; set; }
        public string ModType { get; set; }
        public string Description { get; set; }
        public string DownloadLink { get; set; }
        public DateTime UploadDate { get; set; }
        public int AuthorID { get; set; }

        public string ImageUrl { get; set; }



    }
}
