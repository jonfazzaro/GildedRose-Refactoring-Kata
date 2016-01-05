namespace GildedRose {
    using System.Collections.Generic;

    class GildedRose {
        IList<UpdatableItem> Items;
        public GildedRose(IList<UpdatableItem> items) {
            this.Items = items;
        }

        public void UpdateQuality() {
            foreach (var item in Items)
                item.UpdateQuality();
        }
    }
}