using System.Security.Cryptography.X509Certificates;
namespace prjDecorator;

public class Jacket : ClothingDecorator
{
    public Jacket(Human human) : base(human){}
    
        public override string GetDescription() => base.GetDescription + ", wearing a Jacket";
        public override int GetWarmth() => base.GetWarmth() + 50;
    
}