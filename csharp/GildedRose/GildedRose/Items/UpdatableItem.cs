namespace GildedRose.Items {
    class UpdatableItem : Item {
        public virtual void UpdateQuality() {
            if (Quality > 0) {
                if (Name != "Sulfuras, Hand of Ragnaros") {
                    Quality = Quality - 1;
                }
            }

            if (Name != "Sulfuras, Hand of Ragnaros") {
                SellIn = SellIn - 1;
            }

            if (SellIn < 0) {
                if (Quality > 0) {
                    if (Name != "Sulfuras, Hand of Ragnaros") {
                        Quality = Quality - 1;
                    }
                }
            }
        }
    }
}
