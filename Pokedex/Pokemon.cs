using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Pokedex
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type1 { get; set; }
        public string type2 { get; set; }
        public int total { get; set; }
        public int hp { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int spAtk { get; set; }
        public int spDef { get; set; }
        public int speed { get; set; }
        public string generation { get; set; }
        public bool legendary { get; set; }
        public string picture { get; set; }
    }
}