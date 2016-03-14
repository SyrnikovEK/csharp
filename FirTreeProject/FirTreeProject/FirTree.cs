using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeProject
{
    public class FirTree : ITree
    {
        private double height;
        private double growingSpeed;
        private TreeColor color;
        private TreeType type;
        private TreeShape shape;


        public double Height
        {
            get
            {
                return height;
            }
        }
        public double GrowingSpeed
        {
            get
            {
                return growingSpeed;
            }
            set
            {
                growingSpeed = value;
            }
        }
        public TreeColor Color
        {
            get
            {
                return color;
            }
        }
        public TreeType Type
        {
            get
            {
                return type;
            }
        }
        public TreeShape Shape
        {
            get
            {
                return shape;
            }
        }

        public FirTree()
        {
            height = 0;
            color = TreeColor.Green;
            type = TreeType.FirTree;
            shape = TreeShape.Shapely;
        }

        public void GrowUp(double delta)
        {
            height += delta;
        }

        public void GrowUp()
        {
            height += growingSpeed;
        }
    }
}
