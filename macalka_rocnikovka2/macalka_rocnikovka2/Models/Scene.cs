using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macalka_rocnikovka2.Models
{
    class Scene
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BackgroundImagePath { get; set; }
        public List<GameItem> ItemsInScene { get; set; }
        public List<Character> CharactersInScene { get; set; }
        public int? NextSceneId { get; set; }


        public Scene()
        {
            ItemsInScene = new List<GameItem>();
            CharactersInScene = new List<Character>();
            NextSceneId = null;
        }

        public Scene(int id, string name, string description, string backgroundImagePath)
        {
            Id = id;
            Name = name;
            Description = description;
            BackgroundImagePath = backgroundImagePath;
            ItemsInScene = new List<GameItem>();
            CharactersInScene = new List<Character>();
            NextSceneId = null;
        }

        public void AddItem(GameItem item)
        {
            if (item != null)
            {
                ItemsInScene.Add(item);
            }
        }
        public void RemoveItem(GameItem item)
        {
            if (ItemsInScene.Contains(item))
            {
                ItemsInScene.Remove(item);
            }
        }

        public void AddCharacter(Character character)
            {
                if (character != null)
                {
                    CharactersInScene.Add(character);
                }
        }

        public int GetItemCount()
        {
            return ItemsInScene.Count;
        }   
    }
}
