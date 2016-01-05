namespace GildedRose.Items {
    class BackstagePass : UpdatableItem {

        public BackstagePass() {
            Name = "Backstage passes to a TAFKAL80ETC concert";
        }

        public override void UpdateQuality() {
            if (Quality < 50) {
                Quality++;

                if (SellIn < 11)
                    if (Quality < 50)
                        Quality++;

                if (SellIn < 6)
                    if (Quality < 50)
                        Quality++;
            }

            SellIn--;

            if (SellIn < 0)
                Quality = 0;
        }
    }
}
