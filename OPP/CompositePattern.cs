using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public abstract class Component
    {
        public Component(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public abstract int GetWeight();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);

        protected int weight;
        protected string name;
    }

    public class ItemLeaf : Component
    {
        public ItemLeaf(int weight, string name) : base(weight, name)
        {
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override int GetWeight()
        {
            return weight;
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }

    public class ItemComposite : Component
    {
        private List<Component> components = new();

        public ItemComposite(int weight, string name) : base(weight, name)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override int GetWeight()
        {
            int totalValue = weight;
            foreach (var item in components)
            {
                totalValue += item.GetWeight();
            }
            return totalValue;
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }
    }
}
