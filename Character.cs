using System;
using mis321_pa2_Lcmims1.Interfaces;
namespace mis321_pa2_Lcmims1
{
    public class Character 
    {
        public string Name {get; set;}
        public string Username { get; set; }
        public int MaxPower {get;set;}
        public double Health {get; set;}
        public int AttackStrength {get;set;}
        public int DefensivePower {get; set;}
        public ICharacterBehavior characterbehavior {get;set;}

         public Character(){
            this.characterbehavior = new CharacterBehavior();
            this.Health = 100;
            Random ranNum = new Random();  
            MaxPower = ranNum.Next(1,100);
            DefensivePower = ranNum.Next(1,MaxPower);
            AttackStrength = ranNum.Next(1,MaxPower);
        }

    //     static void PowerStats(){
    //     Random ranNum = new Random();  
    //     int power = ranNum.Next(1,100);
    //     int dpower = ranNum.Next(1,power);
    //     int strength = ranNum.Next(1,power);
    //     //int health = health;
     
    // }

    public void PrintStats(Character player2, double damageDealt){
        System.Console.WriteLine("Current Stats:\n "+this.Name +" took a damage of "+damageDealt+"");
        // System.Console.WriteLine(this.Name);
        System.Console.WriteLine("\nHealth: " + this.Health + "\nMax Power: "+this.MaxPower+" Defense Power: "+this.DefensivePower+" Attack Power: "+this.AttackStrength+"");
        System.Console.WriteLine(player2.Name);
        System.Console.WriteLine("\nHealth: " + player2.Health + "\nMax Power: "+player2.MaxPower+" Defense Power: "+player2.DefensivePower+" Attack Power: "+player2.AttackStrength+"");
    }
    }
}