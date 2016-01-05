﻿namespace GildedRose {
    class UpdatableItem : Item {
        public virtual void UpdateQuality() {
            if (this.Name != "Aged Brie" && this.Name != "Backstage passes to a TAFKAL80ETC concert") {
                if (this.Quality > 0) {
                    if (this.Name != "Sulfuras, Hand of Ragnaros") {
                        this.Quality = this.Quality - 1;
                    }
                }
            } else {
                if (this.Quality < 50) {
                    this.Quality = this.Quality + 1;

                    if (this.Name == "Backstage passes to a TAFKAL80ETC concert") {
                        if (this.SellIn < 11) {
                            if (this.Quality < 50) {
                                this.Quality = this.Quality + 1;
                            }
                        }

                        if (this.SellIn < 6) {
                            if (this.Quality < 50) {
                                this.Quality = this.Quality + 1;
                            }
                        }
                    }
                }
            }

            if (this.Name != "Sulfuras, Hand of Ragnaros") {
                this.SellIn = this.SellIn - 1;
            }

            if (this.SellIn < 0) {
                if (this.Name != "Aged Brie") {
                    if (this.Name != "Backstage passes to a TAFKAL80ETC concert") {
                        if (this.Quality > 0) {
                            if (this.Name != "Sulfuras, Hand of Ragnaros") {
                                this.Quality = this.Quality - 1;
                            }
                        }
                    } else {
                        this.Quality = this.Quality - this.Quality;
                    }
                } else {
                    if (this.Quality < 50) {
                        this.Quality = this.Quality + 1;
                    }
                }
            }
        }
    }
}
