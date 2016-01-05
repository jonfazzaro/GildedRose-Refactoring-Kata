namespace GildedRose.Items {
    class ConjuredItem : UpdatableItem {
        public override void UpdateQuality() {
            if (Quality > 0)
                Quality -= 2;

            SellIn--;

            if (SellIn < 0 && Quality > 0)
                Quality -= 2;
        }
    }
}
