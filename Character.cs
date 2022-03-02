using System;
using mis321_pa2_Lcmims1.Interfaces;
namespace mis321_pa2_Lcmims1
{
    public class Character 
    {
        public string Name {get; set;}
        public int MaxPower {get;set;}
        public double Health {get; set;}
        public int AttackStrength {get;set;}
        public int DefensivePower {get; set;}
        public ICharacterBehavior characterbehavior {get;set;}

         public Character(){
            this.characterbehavior = new CharacterBehavior();
            this.Health = 100;
            Random ranNum = new Random();  
            int power = ranNum.Next(1,100);
            int dpower = ranNum.Next(1,power);
            int strength = ranNum.Next(1,power);
        }

    //     static void PowerStats(){
    //     Random ranNum = new Random();  
    //     int power = ranNum.Next(1,100);
    //     int dpower = ranNum.Next(1,power);
    //     int strength = ranNum.Next(1,power);
    //     //int health = health;
     
    // }

    public void PrintStats(Character player2, double damageDealt){
        System.Console.WriteLine("Current Stats:\n "+ this.Name +" "+this.characterbehavior+ " and "+ player2.Name+" took a damage of "+damageDealt+"");
        System.Console.WriteLine(this.Name);
        System.Console.WriteLine("\n\tHealth: " + this.Health + "\nMax Power: "+this.MaxPower+" Defense Power: "+this.DefensivePower+" Attack Power: "+this.AttackStrength+"");
        System.Console.WriteLine(player2.Name);
        System.Console.WriteLine("\n\tHealth: " + player2.Health + "\nMax Power: "+player2.MaxPower+" Defense Power: "+player2.DefensivePower+" Attack Power: "+player2.AttackStrength+"");
    }
    }
}