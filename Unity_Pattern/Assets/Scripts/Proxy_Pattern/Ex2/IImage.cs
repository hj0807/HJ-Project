using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProxyPattern.ex2
{
    /// <summary>
    /// Subject 역할.
    /// Real Subject와 Proxy에 대한 공용 인터페이스를 정의.
    /// </summary>
    public interface IImage 
    {
        void DisplayImage();
    }
}