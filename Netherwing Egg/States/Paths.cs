using robotManager.Helpful;
using System;
using System.Collections.Generic;
using System.Threading;
using wManager.Wow.Bot.States;
using wManager.Wow.Bot.Tasks;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;

namespace Netherwing_Egg.States
{
    public class PathHandler
    {
        public PathHandler() { }
        public PathHandler(List<Vector3> _path, List<Int32> _Objects)
        {
            path.AddRange(_path);
            Objects.AddRange(_Objects);
        }

        public Boolean pulse()
        {
            if(ObjectFamer == null)
            {
                ObjectFamer = new Farming
                {
                    GatherEntry = this.Objects,
                    ByGatherEntryOnly = true,
                    ForceSkipInOutDoors = true,
                    IgnoreIfPlayerNear = true
                };
            }
            if(MovementExecutor == null)
            {
                MovementExecutor = new MovementLoop
                {
                    PathLoop = this.path,
                    IsLoop = this.IsLoop,
                    DisplayName = "[Egg Pather] "
                };
            }
            if (this.ObjectFamer.NeedToRun)
            {
                this.ObjectFamer.Run();
            }
            else
            if (this.MovementExecutor.NeedToRun)
            {
                if (!ObjectManager.Me.IsFlying)
                {
                    Move.JumpOrAscend(Move.MoveAction.DownKey);
                    Thread.Sleep(5000);
                    Move.JumpOrAscend(Move.MoveAction.UpKey);
                }
                this.MovementExecutor.Run();
            }
            return true;
        }

        public void Stop()
        {
            if (MovementExecutor != null)
            {
                this.MovementExecutor.PathLoop.Clear();
                this.path.Clear();
                this.MovementExecutor = null;
            }
            if(ObjectFamer != null)
            {
                this.ObjectFamer = null;
            }
        }
        private MovementLoop MovementExecutor;

        private wManager.Wow.Bot.States.Farming ObjectFamer;
        private Boolean IsLoop { get; set; } = true;
        private Boolean isHotSpot { get; set; } = false;
        private Boolean Randomise { get; set; } = true;
        public List<Vector3> path = new List<Vector3>();
        public List<Int32> Objects = new List<Int32>();
    }
}

