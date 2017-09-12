using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BridgePatter.ex2
{
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            Shape[] shapes = new Shape[]
            {
                new CircleShape(0, 0, 50, new DrawingAPI1()),
                new CircleShape(30, -30, 30, new DrawingAPI2())
            };

            for(int i=0; i<shapes.Length; i++)
            {
                shapes[i].resizeByPercent(2.5);
                shapes[i].draw();
            }
        }
    }
}