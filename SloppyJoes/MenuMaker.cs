using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoes
{
    class MenuMaker
    {
        private Random random = new Random();
        private List<string> meats = new List<string>() 
        {
            "Roast beef", "Salami", "Turkey", "Ham", "Pastrami"
        };
        private List<string> condiments = new List<string>()
        {
            "Yellow mustard", "Brown mustard", "Honey mustard", "Mayo", "Relish", "French dressing"
        };
        private List<string> breads = new List<string>()
        {
            "Rye", "White", "Wheat", "Pumpernickel", "Italian bread", "a roll"
        };
        public ObservableCollection<MenuItem> Menu { get; private set; }
        public DateTime GeneratedDate { get; private set; }
        public int NumberOfItems { get; set; }

        public MenuMaker()
        {
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
        }

        private MenuItem createMenuItem()
        {
            string randomMeat = meats[random.Next(meats.Count)];
            string randomCondiment = condiments[random.Next(condiments.Count)];
            string randomBread = breads[random.Next(breads.Count)];
            return new MenuItem(randomMeat, randomCondiment, randomBread);
        }

        public void UpdateMenu()
        {
            Menu.Clear();
            for (int i = 0; i < NumberOfItems; i++)
            {
                Menu.Add(createMenuItem());
            }
            GeneratedDate = DateTime.Now;
        }
    }
}
