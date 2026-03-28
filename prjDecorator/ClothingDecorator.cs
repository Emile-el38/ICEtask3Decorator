namespace prjDecorator;

public abstract class ClothingDecorator : Human
{
    private readonly Human _human;

    protected ClothingDecorator (Human human)
    {
        _human = human;
    }


    //concrete decorators only ovveride what they change
    public override string GetDescription() => _human.GetDescription();
    public override int GetWarmth() => _human.GetWarmth();
}