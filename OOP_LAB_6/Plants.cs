﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LAB_6
{
    public class Plants : IPlants
    {
        public string Name { get; set; }
        public string Kingdom { get; set; }
        public string Family { get; set; }
        public int Result { get; set; }
        public int Leafs { get; set; }
        public enum Days { Saturday = 1, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday };
        public Plants() { }
        public Plants(string name,string family, string kingdom)
        {
            Name = name;
            Family = family;
            Kingdom = kingdom;
        }
        public string GetInfo()
        {
            return $"INFO ABOUT OBJECT \n{GetType()} \nName : {Name} \nFamily : {Family} \nKingdom : {Kingdom}";
        }
        public override string ToString()
        {
            return $"CLASS INFORMATION \nType : {GetType()} \nName : {Name} \nFamily : {Family} \nKingdom : {Kingdom}";
        }
    }
}
