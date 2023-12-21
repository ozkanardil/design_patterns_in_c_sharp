using DecoratorDesignPattern.Assets;

namespace DecoratorDesignPattern.Decorator
{
    public abstract class AbstractDecorator : Component
    {
        protected Component com;
        public void SetTheComponent(Component c)
        {
            com = c;
        }
        public override void MakeHouse()
        {
            if (com != null)
            {
                com.MakeHouse();//Delegating the task
            }
        }
    }
}
