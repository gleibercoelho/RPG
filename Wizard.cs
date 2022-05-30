namespace dungeons_dio.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name =  Name;
            this.Level = Level;
            this.HeroType = HeroType;   
        }

         public override string Attack(){
            return this.Name + " Lançou Magia";
        }
        
        public string Attack(int Bonus)
        {
        if(Bonus > 6){
            return this.Name + " Lançou uma magia super efetiva com bonus " + Bonus;
        }
        else
        {
            return this.Name +" Lançou uma magia com força fraca com Bonus " + Bonus;
        }    
            

        }
    }
    
}