using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePattern.ex1
{
    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            //Debug.Log("Component 생성자 : " + name);
            this.name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            Debug.Log("Can't add to a leaf");
        }

        public override void Remove(Component component)
        {
            Debug.Log("Can't remove from a leaf");
        }

        public override void Display(int depth)
        {
            Debug.Log(new string('-', depth) + name);
        }
    }

    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name):base(name)
        {
            //Debug.Log("====Composite생성자 : " + name);
            this.name = name;
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Debug.Log(new string('-', depth) + name);

            for(int i=0; i<_children.Count; i++)
            {
                _children[i].Display(depth + 2);
            }
        }
    }
}