using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    public abstract class Shape
    {
        private Color _colour;
        private float _x, _y;
        private bool _selected;

        public Shape(Color color)
        {
            _colour = color;
        }

        public Shape() : this(Color.Yellow)
        {

        }

        public abstract void Draw();

        public abstract void DrawOutline();

        public abstract bool IsAt(Point2D point);

        public Color Color
        {
            get
            {
                return _colour;
            }
            set
            { 
                _colour = value;
            }
        }
        public float X
        {
            get
            {
                return _x;
            } 
            set
            {
                _x = value;
            }
        }
        public float Y
        {
            get
            {
                return _y;
            } 
            set
            {
                _y = value;
            }
        }
        public bool Selected
        {
            get
            {
                return _selected;
            } 
            set
            {
                _selected = value;
            }
        }


    }
}
