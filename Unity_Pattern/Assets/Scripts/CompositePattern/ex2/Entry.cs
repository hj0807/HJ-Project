using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CompositePattern.ex2
{
    /// <summary>
    /// Component 역할
    /// Composition(복합 개체)를 위한 추상화 클래스
    /// </summary>
    public abstract class Entry
    {
        public abstract string GetName();
        public abstract int GetSize();

        public abstract Entry Add(Entry entry);

        public abstract void PrintList(string prefix);

        //공통으로 사용되는 출력 method.
        public void Print()
        {
            PrintList(" ");
        }

        public string ToString()
        {
            return string.Format("{0} ({1})", GetName(), GetSize());
        }
    }

    public class File : Entry
    {
        private string name;
        private int size;

        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public override Entry Add(Entry entry)
        {
            throw new System.NotImplementedException();
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            return size;
        }

        public override void PrintList(string prefix)
        {
            Debug.Log(prefix + "/" + this.name);
        }
    }

    public class Folder : Entry
    {
        private string name;
        private List<Entry> directoryList = new List<Entry>();

        public Folder(string name)
        {
            this.name = name;
        }

        public override Entry Add(Entry entry)
        {
            directoryList.Add(entry);
            return this;
        }

        public override string GetName()
        {
            return name;
        }

        public override int GetSize()
        {
            int totalSize = 0;

            for(int i=0; i<directoryList.Count; i++)
            {
                totalSize += directoryList[i].GetSize();
            }

            return totalSize;
        }

        public override void PrintList(string prefix)
        {
            Debug.Log(prefix + "/" + this.name);

            for(int i=0; i<directoryList.Count; i++)
            {
                Entry entry = directoryList[i];
                entry.PrintList(prefix + "/" + name);
            }
        }
    }
}