using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
using System.IO;

namespace ShapeDrawer
{
    class MyCircle : Shape
    {
        private int _radius;
        public MyCircle(Color clr, int radius) : base(clr)
        {
            _radius = radius;
        }

        public MyCircle() : this(Color.Blue, 50)
        {

        }
        public override void Draw()
        {
            if (Selected) DrawOutline();
            SplashKit.FillCircle(Color, X, Y, _radius);
        }


        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Black, X, Y, _radius + 2);
        }
        public override bool IsAt(Point2D point)
        {
            if (SplashKit.PointInCircle(point, SplashKit.CircleAt(X, Y, _radius)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Circle");
            base.SaveTo(writer);
            writer.WriteLine(Radius);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            Radius = reader.ReadInteger();
        }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
    }
}
