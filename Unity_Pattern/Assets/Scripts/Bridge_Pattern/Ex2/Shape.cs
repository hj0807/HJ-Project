using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern.ex2
{
    public abstract class Shape {
        protected DrawingAPI drawingAPI;

        public Shape(DrawingAPI drawingAPI)
        {
            this.drawingAPI = drawingAPI;
        }

        public abstract void draw();
        public abstract void resizeByPercent(double pct);
    }

    public class CircleShape : Shape
    {
        private double x, y, r;

        public CircleShape(double x, double y, double r, DrawingAPI drawingAPI) : base(drawingAPI)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public override void draw()
        {
            drawingAPI.DrawCircle(x, y, r);
        }

        public override void resizeByPercent(double pct)
        {
            r *= pct;
        }
    }
}