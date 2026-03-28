namespace prjDecorator;

public class Raincoat : ClothingDecorator
{
    public Raincoat(Human human) : base(human){}
    
        public override string GetDescription() => base. GetDescription() + ", wearing a Raincoat";
        public override int GetWarmth() => base.GetWarmth() + 5;

}