namespace GildedRose.Items {
    class AgedBrie : UpdatableItem {
        public AgedBrie() {
            Name = "Aged Brie";
        }

        public override void UpdateQuality() {
            if (Quality < 50)
                Quality++;

            SellIn--;

            if (SellIn < 0 && Quality < 50)
                Quality++;
        }
    }
}
