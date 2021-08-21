using System;
using System.Collections.Generic;

namespace TamagotchiAPI.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int HungerLevel { get; set; }
        public int HappinessLevel { get; set; }
        public DateTime LastInteractedWithDate { get; set; }
        public bool IsDead
        {
            get
            {
                if (LastInteractedWithDate.AddDays(3) < DateTime.Now || HungerLevel > 50 || HappinessLevel < -50)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}