namespace prjDecorator;
public class Sweater : ClothingDecorator
{
    public Sweater(Human human) : base(human) {}

    public override string GetDescription() => base.GetDescription() + ", wearing a Sweater";
    public override int GetWarmth() => base.GetWarmth() + 20;
}