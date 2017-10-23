using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CommandPatter.ex2
{
    public interface ICommand
    {
        void Execute();
    }

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