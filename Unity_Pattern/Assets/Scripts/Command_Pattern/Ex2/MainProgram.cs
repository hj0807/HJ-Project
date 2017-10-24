using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CommandPatter.ex2
{
    public class MainProgram : MonoBehaviour
    {
        void Main()
        {
            Player player = new Player();

            MacroPattern pattern = new MacroPattern();

            pattern.Add(new Movement(player));
            pattern.Add(new Attack(player));

            pattern.Run();
        }
    }
}