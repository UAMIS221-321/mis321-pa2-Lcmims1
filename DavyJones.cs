using mis321_pa2_Lcmims1.Interfaces;
namespace mis321_pa2_Lcmims1
{
    public class DavyJones : ICharacterBehavior
    {

       
       public void Attack(Character player1, Character player2){
           System.Console.WriteLine("Davy Jones has attacked with Cannon Fire");
           double damageDealt = 0.0;
           if(player2.Name == "Jack Sparrow"){
            damageDealt = (player2.AttackStrength - player2.DefensivePower) *1.2;
            player2.Health -= damageDealt;
        }
        else {
            player2.Health = player2.AttackStrength - player2.DefensivePower;
        }
            player2.PrintStats(player2, damageDealt);
    }
    }
}
    //    public void Defend(){
    //        System.Console.WriteLine("I am defending myself");
    //    }