﻿namespace Labyrinth.Commands
{   
    using System;

    using Labyrinth.Renderer;
    using Users;

    public class GameCommand : Command
    {
        private LabyrinthProcesor labyrinthProcesor;
        private IScoreBoardObserver scoreboardHandler;
        private IRenderer renderer;
        private IPlayer player;
        private string command;

        public GameCommand(LabyrinthProcesor labyrinthProcesor, IScoreBoardObserver scoreboardHandler, IRenderer renderer, IPlayer player, string command)
        {
            this.labyrinthProcesor = labyrinthProcesor;
            this.scoreboardHandler = scoreboardHandler;
            this.renderer = renderer;
            this.player = player;
            this.command = command;
        }

        public override void Execute()
        {
            switch (this.command)
            {
                case "top": this.scoreboardHandler.ShowScoreboard();
                    break;

                case "restart": this.labyrinthProcesor.Restart();
                    break;

                case "exit": this.renderer.ShowMessage(Messenger.GoodBye);
                    System.Environment.Exit(0);
                    break;

                case "newplayer": this.renderer.ShowMessage(Messenger.ChangePlayer);
                    this.AddNewPlayer();
                    break;

                default: this.renderer.ShowMessage(Messenger.InvalidMoveMessage);
                    break;
            }
        }

        private void AddNewPlayer()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            this.player.Name = userName;
            this.labyrinthProcesor.Restart();
        }
    }
}
