using System;
using System.Collections.Generic;

namespace Bees {
    class Beehive
    {
        public int MaxBees { get; set; }
        public List<Bee> Bees { get; set; }
       
        public Beehive(int maxBees)
        {
            MaxBees = maxBees;
            Bees = new List<Bee>();
            
        }

        public void AddBee(Bee bee){
            if (this.Bees.Count < this.MaxBees) {
                this.Bees.Add(bee);
            } else {
                Console.WriteLine("Beehive is already full");
            }
        }

        public float CollectHoney(int days){
            float totalhoney = 0F;
            
            foreach (Bee bee in this.Bees)
            {
                totalhoney += bee.Size * 0.2F;
            }

            totalhoney *= days;

            return totalhoney;
        }
    }
  
}