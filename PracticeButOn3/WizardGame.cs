using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp {
    class WizardGame {

        public string Item { get; set; }
        public string Command { get; set; }


        public string[] items = { "wooden staff", "wizard hat", "cloth shoes", "" };

        
        public string ShowItems() {
            return items.ToString();       
        }

        public void GrabItems(string Item) {
            items[4] = Item;
        }

        public void UpdateItems(string Item) {
            items[Array.IndexOf(items, $"{Item}")] = "";       
        }

        public void DropItems(string Item) {
            items[Array.IndexOf(items, $"{Item}")] = "Empty";
        }




    }
}
