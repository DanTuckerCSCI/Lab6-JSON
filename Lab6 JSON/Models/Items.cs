using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_JSON.Models
{
    public class Items
    {
        public string Id { get; set; } 
        public string SelfLink { get; set; }
        public VolumeInfo VolumeInfo { get; set; }

        public Items (string id, string selfLink, VolumeInfo volumeInfo)
        {
            Id = id;
            SelfLink = selfLink;
            VolumeInfo = volumeInfo;
        }   
    }
}
