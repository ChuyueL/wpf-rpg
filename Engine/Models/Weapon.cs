﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        //when we instantiate a weapon object, it takes the values we passed in and sends them to the base class.
        //This sets the properties.
        public Weapon(int itemTypeID, string name, int price, int minDamage, int maxDamage) 
            : base(itemTypeID, name, price)
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
        }

        //new overrides the GameItem function of same name
        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MinimumDamage, MaximumDamage);
        }
    }
}
 