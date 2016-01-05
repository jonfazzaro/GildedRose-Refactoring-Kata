using GildedRose.Items;
using System.Collections.Generic;

namespace GildedRose {
    class Program {
        public static void Main(string[] args) {
            System.Console.WriteLine("OMGHAI!");

            IList<UpdatableItem> Items = new List<UpdatableItem>{
                new UpdatableItem {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new AgedBrie {SellIn = 2, Quality = 0},
                new UpdatableItem {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Sulfuras {SellIn = 0, Quality = 80},
                new Sulfuras {SellIn = -1, Quality = 80},
                new BackstagePass
                {
                    SellIn = 15,
                    Quality = 20
                },
                new BackstagePass
                {
                    SellIn = 10,
                    Quality = 49
                },
                new BackstagePass
                {
                    SellIn = 5,
                    Quality = 49
                },
                new ConjuredItem {Name = "Conjured Mana Cake", SellIn = 3, Quality = 16}
            };

            var app = new GildedRose(Items);


            for (var i = 0; i < 31; i++) {
                System.Console.WriteLine("-------- day " + i + " --------");
                System.Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++) {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                }
                System.Console.WriteLine("");
                app.UpdateQuality();
            }

        }

    }
}
