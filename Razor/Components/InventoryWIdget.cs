﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Razor.Components
{
    public class InventoryWIdget : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var inventory = new List<InventoryItem>()
            {
                new InventoryItem() {  Name = "Banner", Count = 8 },
                new InventoryItem() {  Name = "Markers", Count = 3 },
                new InventoryItem() {  Name = "Jacket", Count = 14 },
                new InventoryItem() {  Name = "Hoodie", Count = 1 },
                new InventoryItem() {  Name = "Poster", Count = 6 },
                new InventoryItem() {  Name = "Pens", Count = 16 }
            };

            return View(inventory);
        }
    }

    public class InventoryItem
    {
        public InventoryItem(string name, int count)
        {
            Count = count;
            Name = name;
        }

        public int Count { get; set; }
        public string Name { get; set; }
    }
}