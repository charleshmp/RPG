using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_POO.src.Entities
{
    public class Wizard : Hero{
    public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack(){
            return this.Name + "Lançou Magia";
        }
        public string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + "Lançou Magia Super efetiva com bonus de " + Bonus;
            }else{
            return this.Name + " Lançou magia com força fraca com Bonus de ataque" + Bonus; 
            }
        }
    }
}