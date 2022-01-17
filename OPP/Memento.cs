using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class Game
    {
        int windowSizeX = 400;
        int windowSizeY = 400;
        string gameName = "Gamer";
        string gameVersion = "2.0";

        public string status = "running";

        public Memento CreateMemento()
        {
            return new Memento(status);
        }

        public void SetMemento(Memento m)
        {
            status = m.status;
        }
    }

    public class Memento
    {
        public string status;

        public Memento(string status)
        {
            this.status = status;
        }
    }

    public class Caretaker
    {
        List<Memento> mementos = new List<Memento>();
        Game game;
        
        public Caretaker(Game game)
        {
            this.game = game;
        }


        public void CreateSnapshot()
        {
            mementos.Add(game.CreateMemento());
        }

        public void RestoreToPreviousState()
        {
            Memento a = mementos.Last();
            game.SetMemento(a);
            mementos.Remove(a);
        }
    }
}
