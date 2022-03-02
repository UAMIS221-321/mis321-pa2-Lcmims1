using mis321_pa2_Lcmims1.Interfaces;
namespace mis321_pa2_Lcmims1
{
    public class Sword 
    {
        public ICharacterBehavior characterbehavior{get;set;}
        public Sword (){
            characterbehavior = new CharacterBehavior();
        }
    }
}