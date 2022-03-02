using mis321_pa2_Lcmims1.Interfaces;
namespace mis321_pa2_Lcmims1
{
    public class DistractOpponent
    {
        public ICharacterBehavior characterbehavior{get;set;}
        public DistractOpponent (){
            characterbehavior = new CharacterBehavior();
        }
    }
}