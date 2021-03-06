﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonPattern.ex1
{
    public class MonoSingleton : MonoBehaviour
    {
        private static MonoSingleton instance;

        public static MonoSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindObjectOfType<MonoSingleton>();
                }

                if (instance == null)
                {
                    instance = new MonoSingleton();
                    GameObject obj = new GameObject("SingtonObj");
                    instance = obj.AddComponent<MonoSingleton>();
                }
                return instance;
            }
        }
    }

}