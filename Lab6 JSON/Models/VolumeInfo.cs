using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_JSON.Models
{
    public class VolumeInfo
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public string Description { get; set; } 

        public VolumeInfo(string title, string[] authors, string description)
        {
            Title = title;
            Authors = authors;
            Description = description;  

        }
    }
}
