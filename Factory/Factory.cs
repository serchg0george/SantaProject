using SantaProject.Interfaces;

namespace SantaProject.Factories
{
    public abstract class Factory
    {
        public abstract IProduct GetProduct();
    }
}
