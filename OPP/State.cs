using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class Player
    {
        private PlayerState state;

        public Player()
        {
            state = new WalkingState(this);
        }

        public int GetMovementSpeed()
        {
            return state.GetMovementSpeed();
        }

        public string GetHitbox()
        {
            return state.GetHitbox();
        }

        public void ChangeState(PlayerState state)
        {
            this.state = state;
        }
    }
    
    public abstract class PlayerState
    {
        protected Player player;

        public PlayerState(Player player)
        {
            this.player = player;
        }

        public abstract int GetMovementSpeed();
        public abstract string GetHitbox();

    }

    public class WalkingState : PlayerState
    {
        public WalkingState(Player player) : base(player)
        {
        }

        public override string GetHitbox()
        {
            return "Normal hitbox";
        }

        public override int GetMovementSpeed()
        {
            return 5;
        }
    }

    public class CrawlingState : PlayerState
    {
        public CrawlingState(Player player) : base(player)
        {
        }

        public override string GetHitbox()
        {
            return "Small hitbox";
        }

        public override int GetMovementSpeed()
        {
            return 2;
        }
    }

    public class RunningState : PlayerState
    {
        public RunningState(Player player) : base(player)
        {
        }

        public override string GetHitbox()
        {
            return "Large hitbox";
        }

        public override int GetMovementSpeed()
        {
            player.ChangeState(new WalkingState(player));
            return 10;
        }
    }
}
