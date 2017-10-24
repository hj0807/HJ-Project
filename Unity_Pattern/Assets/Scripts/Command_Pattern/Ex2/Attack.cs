using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPatter.ex2
{
    public class Attack : ICommand
    {
        private Player player;

        public Attack(Player player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.Attack();
        }
    }
}