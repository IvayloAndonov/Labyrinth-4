﻿namespace Labyrinth.Commands
{
    using System;

    using Labyrinth.Contexts;
    using Labyrinth.Utilities;

    /// <summary>
    /// The class performs exit from the game.
    /// </summary>
    public class ExitCommand : ICommand
    {
        /// <summary>
        ///  Gets an instance of a exit command
        /// </summary>
        /// <param name="context">Accepts the current game context.</param>      
        public ExitCommand(IContext context)
        {
            this.Context = context;
        }

        public IContext Context { get; private set; }

        /// <summary>
        /// Shows exit message and performs exit.
        /// </summary>
        public void Execute()
        {
            this.Context.Renderer.ShowMessage(Messages.GoodBye);
            System.Environment.Exit(0);
        }
    }
}