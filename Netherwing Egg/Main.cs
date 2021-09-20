using Custom_Profile;
using robotManager.FiniteStateMachine;
using robotManager.Helpful;
using System;
using wManager.Plugin;
using wManager.Wow.Bot.States;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;
using ToolHandler;
using Netherwing_Egg.States;
using Netherwing_Egg.EventHandler;

public class CustomProfile : ICustomProfile
{

    private static readonly Engine engine = new Engine();
    public  static readonly String CustomProfileName = "[Netherwing Egg]: ";
    public  static PathHandler _Load = null;
    public void Pulse()
    {
        try
        {
            Logging.Write($"{CustomProfileName} Started.");
            SpellManager.UpdateSpellBook();
            CustomClass.LoadCustomClass();
            PluginsManager.LoadAllPlugins();
            BindOnPickUp.Start();

            engine.States.Clear();
            engine.AddState(new Relogger { Priority = 200 });
            engine.AddState(new Pause { Priority = 6 });
            engine.AddState(new Resurrect { Priority = 5 });
            engine.AddState(new IsAttacked { Priority = 4 });
            engine.AddState(new Looting { Priority = 3 });
            engine.AddState(new EggFinder { Priority = 1 });
            engine.AddState(new Idle { Priority = 0 });
            engine.States.Sort();
            engine.StartEngine(15);

        }
        catch(Exception ex)
        {
            Logging.WriteError($"{CustomProfileName} > pulse > {ex}");
        }
    }
    public void Dispose()
    {
        try
        {
            _Load.Stop();
            BindOnPickUp.Stop();
            Logging.Write($"{CustomProfileName} Stopped.");
            engine.StopEngine();
        }
        catch(Exception ex)
        {
            Logging.WriteError($"{CustomProfileName} > Dispose > {ex}");
        }
    }
}
