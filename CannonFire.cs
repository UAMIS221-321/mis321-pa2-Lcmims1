using mis321_pa2_Lcmims1.Interfaces;
namespace mis321_pa2_Lcmims1
{
    public class CannonFire 
    {
        public ICharacterBehavior characterbehavior{get;set;}
        public CannonFire (){
            characterbehavior = new CharacterBehavior();
        }
    }
}