using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macalka_rocnikovka2.Models
{
    class GameItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool IsInInventory { get; set; }


        public GameItem()
        {
            IsInInventory = false;

        }

        public GameItem(string id, string name, string description, string imagePath)
        {
            Id = id;
            Name = name;
            Description = description;
            ImagePath = imagePath;
            IsInInventory = false;
        }
    }
}
