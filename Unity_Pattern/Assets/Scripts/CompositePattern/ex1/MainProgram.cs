using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePattern.ex1
{
    public class MainProgram : MonoBehaviour
    {
        void Start()
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite composite = new Composite("Composite X");
            composite.Add(new Leaf("Leaf XA"));
            composite.Add(new Leaf("Leaf XB"));

            root.Add(composite);
            root.Add(new Leaf("Leaf C"));

            //Add and Remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
        }
    }
}
