using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;
        private List<Shape> result;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this (Color.White)
        {
            
        }

        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(pt))
                {
                    s.Selected = true;
                }
            }
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }
        public void RemoveShape(Shape s)
        {
            _shapes.Remove(s);
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);

            for (int i = 0; i < _shapes.Count; i++)
            {
                _shapes[i].Draw();
            }
        }
        
        public List<Shape> SelectedShapes
        {
            get
            {
                result = new List<Shape>();
                foreach (Shape s in _shapes)
                {
                    if (s.Selected)
                    {
                        result.Add(s);
                    }
                }
                return result;
            }
        }
        public int ShapeCount
        {
            get{ return _shapes.Count; }
        }   
        public Color Background
        {
            get{ return _background; }
            set{ _background = value;}
        }
    }
}
