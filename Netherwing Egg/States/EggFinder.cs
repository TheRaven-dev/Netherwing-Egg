using robotManager.FiniteStateMachine;
using System.Collections.Generic;
using ToolHandler;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;

namespace Netherwing_Egg.States
{
    public class EggFinder : State
    {
        public override int Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }
        private int _priority;

        public override bool NeedToRun
        {
            get
            {
                if (ObjectManager.Me.IsDead || !Conditions.InGameAndConnectedAndAliveAndProductStartedNotInPause || CustomProfile._Load != null)
                    return false;



                return CustomProfile._Load == null; //&& ObjectManager.Me.GetFactionStanding("Netherwing") >= Tools.FactionStandingRank.Neutral;
            }
        }

        public override List<State> NextStates
        {
            get { return new List<State>(); }
        }

        public override List<State> BeforeStates
        {
            get { return new List<State>(); }
        }

        public override void Run()
        {
            CustomProfile._Load = new PathHandler(Egg.VectorPath, Egg.ObjectEntry);
            CustomProfile._Load.pulse();
        }
    }
}
