﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Shape
    {
        private Color _colour;
        private float _x, _y;
        private int _width, _height;

        public Shape()
        {
            _colour = Color.Green;
            _width = 100;
            _height = 100;
            _x = 0;
            _y = 0;
        }

        public void Draw()
        {
            SplashKit.FillRectangle(_colour, _x, _y, _width, _height);
        }

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
        public int Width
        {
            get
            {
                return _width;
            } 
            set
            {
                _width = value;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            } 
            set
            {
                _height = value;
            }
        }

        public bool IsAt(Point2D point)
        {
            if (((point.X > _x) && (point.X < _x + _width)) && ((point.Y > _y) && (point.Y < _y + _height)))
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
