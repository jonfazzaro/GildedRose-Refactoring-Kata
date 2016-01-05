namespace GildedRose.Items {
    class UpdatableItem : Item {
        public virtual void UpdateQuality() {
            if (Quality > 0)
                Quality--;

            SellIn--;

            if (SellIn < 0 && Quality > 0)
                Quality--;
        }
    }
}
