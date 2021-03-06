﻿namespace Labyrinth.ObjectBuilder
{
    using Model;      
    using Renderer;
    using Scoreboard;
    using Users;
    using Utilities; 
 
    /// <summary>
    /// The 'Builder' abstract class
    /// Specifies an abstract interface for creating all need objects for running the game.
    /// </summary>
    public interface IGameObjectBuilder
    {
        IRenderer CreteRenderer();

        IPlayer CreatePlayer();

        IScoreboard CreateScoreboard();

        IScoreBoardObserver CreteScoreBoardHanler(IScoreboard scoreboard);

        LabyrinthMatrix CreateLabyrinthMatrix();

        string GetUserName();
    }
}
