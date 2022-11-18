using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_JSON.Models
{
    public class Book
    {
       public Items[] Items { get; set; }

       public Book(Items[] items)
        {
            Items = items;  
        }
        public override string ToString()
        {
            string bookString = "";
            bookString += $"ID: {string Id}
            bookString += $"SelfLink:
            bookString += $"VolumeInfo:
            bookString += $"Title:
            bookString += $"Authors:
            bookString += $"Description:

        }
    }
}
