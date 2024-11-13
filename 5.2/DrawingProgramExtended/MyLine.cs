using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
using System.IO;

namespace ShapeDrawer
{
    class MyLine : Shape
    {
        private float _endX, _endY;

        public MyLine(Color clr, float StartX, float StartY, float endX, float endY) : base(clr)
        {
            X = StartX;
            Y = StartY;
            _endX = X + 100;
            _endY = endY;
        }
        public MyLine() : this (Color.Red, 0, 0, 0, 0)
        {
        }

        public override void Draw()
        {
            if (Selected) DrawOutline();
            SplashKit.DrawLine(Color, X, Y, X + 100, Y);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color, X, Y, 5);    
            SplashKit.DrawCircle(Color, X + 100, Y, 5);
        }

        public override bool IsAt(Point2D point)
        {
            //Console.WriteLine("EndX at:" + EndX + "\nEnd Y at:" + EndY);
            if (SplashKit.PointOnLine(point, SplashKit.LineFrom(X, Y, EndX, EndY)))
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
            writer.WriteLine("Line");
            base.SaveTo(writer);
            //writer.WriteLine(Width);
            //writer.WriteLine(Height);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
        }


        public float EndX
        {
            get { return this.X + 100; }
            set { _endX = value; }
        }
        public float EndY
        {
            get { return Y; }
            set { _endY = value; }
        }

    }
}
