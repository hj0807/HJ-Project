using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePattern.ex2
{
    public interface DrawingAPI
    {
        void DrawCircle(double x, double y, double r);
    }

    public class DrawingAPI1 : DrawingAPI
    {
        public void DrawCircle(double x, double y, double r)
        {
            Debug.Log(string.Format("API 1. ({0}, {1}) radius : {2}", x, y, r));
        }
    }

    public class DrawingAPI2 : DrawingAPI
    {
        public void DrawCircle(double x, double y, double r)
        {
            Debug.Log(string.Format("API 2. ({0}, {1}) radius : {2}", x, y, r));
        }
    }
}
