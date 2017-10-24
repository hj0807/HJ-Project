using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPatter.ex2
{
    public class Movement : ICommand
    {
        private Player player;

        public Movement(Player player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.Move();
        }
    }
}