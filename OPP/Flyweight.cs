using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class Tree
    {
        private int x, y;
        private TreeTypeFlyweight type;

        public Tree(int x, int y, TreeTypeFlyweight type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }
    }

    public class Forest
    {
        List<Tree> trees = new();
        TreeTypeFlyweightFactory factory = new TreeTypeFlyweightFactory();

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            trees.Add(new Tree(x, y, factory.GetTreeType(name, color, texture)));
        }
    }

    public class TreeTypeFlyweightFactory
    {
        List<TreeTypeFlyweight> treeTypes = new();
        
        public TreeTypeFlyweight GetTreeType(string name, string color, string texture)
        {
            TreeTypeFlyweight retrievedType = treeTypes.Where(type =>
                type.name == name &&
                type.color == color &&
                type.texture == texture).SingleOrDefault();

            if (retrievedType == null)
            {
                Console.WriteLine("Creating new flyweight");
                retrievedType = new TreeTypeFlyweight(name, color, texture);
                treeTypes.Add(retrievedType);
            }
            else
            {
                Console.WriteLine("Reusing old flyweight");
            }

            return retrievedType;
        }
    }

    public class TreeTypeFlyweight
    {
        public string name;
        public string color;
        public string texture;

        public TreeTypeFlyweight(string name, string color, string texture)
        {
            this.name = name;
            this.color = color;
            this.texture = texture;
        }
    }
}
