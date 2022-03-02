using mis321_pa2_Lcmims1.Interfaces;
namespace mis321_pa2_Lcmims1
{
    public class WillTurner : ICharacterBehavior
    {

     
         public double Attack(Character player1, Character player2){
           System.Console.WriteLine("Will Turner has attacked with his sword");
           double damageDealt = 0.0;
            if(player2.Name == "Davy Jones"){
               damageDealt = (player2.AttackStrength - player2.DefensivePower) *1.2;
               player2.Health -= damageDealt;
            }
            else {
            player2.Health = player2.AttackStrength - player2.DefensivePower;
        }
            player1.PrintStats(player2, damageDealt);
            return damageDealt;
        }   

    }
}
    //    public void Defend(){
    //        System.Console.WriteLine("I am defending myself");
    //    }