using robotManager.Helpful;
using System;
using System.Collections.Generic;
using wManager.Wow.Helpers;

namespace Netherwing_Egg.EventHandler
{
    public static class BindOnPickUp
    {
        public static void Start()
        {
            EventsLuaWithArgs.OnEventsLuaStringWithArgs += _BindOnPickUp;
        }

        public static void Stop()
        {
            EventsLuaWithArgs.OnEventsLuaStringWithArgs += _BindOnPickUp;
        }

        private static void _BindOnPickUp(string Events, List<string> args)
        {
            try
            {
                if (Events.ToString() == "LOOT_BIND_CONFIRM")
                {
                    Lua.LuaDoString($"ConfirmLootSlot({args[0]})");
                }
            }
            catch(Exception ex)
            {
                Logging.WriteError($"{CustomProfile.CustomProfileName} > Auto Loot Bind on Pick Up > {ex}");
            }
        }
    }
}
