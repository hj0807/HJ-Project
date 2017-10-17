using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern.ex2
{
    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            //프록시 객체 생성.

            //프록시 객체만 생성해놓는것일뿐 RealImage 객체가 생성되는 것은 X.
            IImage image1 = new ProxyImage("Photo1"); 
            IImage image2 = new ProxyImage("Photo2");

            //여기부분에서 실제 RealImage 객체가 생성됨.(실제 사용시 생성)
            image1.DisplayImage(); //로딩 필요.(처음 1회)
            image1.DisplayImage();

            image2.DisplayImage(); //로딩 필요.(처음 1회)
            image2.DisplayImage();

            image1.DisplayImage();
        }
    }
}