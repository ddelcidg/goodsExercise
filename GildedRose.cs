using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                UpdateItemQuality(item);
                UpdateItemSellIn(item);

                if (item.SellIn < 0)
                {
                    HandleExpiredItem(item);
                }
            }
        }

        private void UpdateItemQuality(Item item)
        {
            if (item.Name.Equals( GoodsTypes.AgedBrie, StringComparison.OrdinalIgnoreCase))
            {
                IncreaseQuality(item);
            }
            else if (item.Name.Equals(GoodsTypes.BackstagePasses, StringComparison.OrdinalIgnoreCase))
            {
                HandleBackstagePasses(item);
            }
            else if (item.Name.Equals(GoodsTypes.Sulfuras, StringComparison.OrdinalIgnoreCase))
            {
                // Sulfuras quality and sellIn do not change
                //I only leave this to show that will be not be doing anything.
                //for other purposes, this may could have other logic
            }
            else if (item.Name.Equals(GoodsTypes.ConjuredManaCake, StringComparison.OrdinalIgnoreCase))
            {
                DecreaseQuality(item, 2);
            }
            else
            {
               // I assumed a general new item will decrease in 1 too, of course this could change
               //depending of the needings in the future
                DecreaseQuality(item, 1);
            }
        }

        private void UpdateItemSellIn(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn--;
            }
        }

        private void HandleExpiredItem(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                IncreaseQuality(item);
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                item.Quality = 0;
            }
            else if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                if (item.Name == "Conjured Mana Cake")
                {
                    DecreaseQuality(item, 2);
                }
                else
                {
                    DecreaseQuality(item, 1);
                }
            }
        }

        private void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }

        private void DecreaseQuality(Item item, int amount)
        {
            if (item.Quality > 0)
            {
                item.Quality -= item.Quality >= amount ? amount : item.Quality;
            }
        }

        private void HandleBackstagePasses(Item item)
        {
            IncreaseQuality(item);

            if (item.SellIn < 11)
            {
                IncreaseQuality(item);
            }

            if (item.SellIn < 6)
            {
                IncreaseQuality(item);
            }
        }

        
    }
}
