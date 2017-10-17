using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 대리자로써 일을 맡기면, 그 일을 처리하고 결과를 알려주는 패턴.
/// </summary>
namespace ProxyPattern.ex1
{
    //Proxy, Real
    public interface ISubject
    {
        void Request();
    }
}