using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp {
    public class WizardGame {

        public string Item { get; set; }
        public string Command { get; set; }


        public string[] items = new string[4] { "wooden staff", "wizard hat", "cloth shoes", "taco" };

        public void SetCommand(string command) {
            command = Command;
        }

        public string ShowItems() {
            return (items[0]+", "+items[1] + ", " + items[2] + ", " + items[3]);
        }

        public void AddItems(string Item) {
            items[Array.IndexOf(items,"Empty")] = Item;
        }

        public void UpdateItems(string edit) {
            items[Array.IndexOf(items, $"{Item}")] = edit;       
        }

        public void DropItems(string Item) {
            items[Array.IndexOf(items, $"{Item}")] = "Empty";
        }




    }
}
