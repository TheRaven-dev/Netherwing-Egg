using robotManager.Helpful;
using System;
using wManager.Wow.Helpers;
using wManager.Wow.ObjectManager;

namespace ToolHandler
{
    public static class Tools
    {
        public enum FactionStandingRank
        {
            Unknown = 0,
            Hated = 1,
            Hostile = 2,
            Unfriendly = 3,
            Neutral = 4,
            Friendly = 5,
            Honored = 6,
            Revered = 7,
            Exalted = 8
        }

        public static FactionStandingRank GetFactionStanding(this WoWLocalPlayer player, String FactionName)
        {
            Int32 results = 0;
            try
            {
                var Faction = @"for f = 1, GetNumFactions() do
                                    local GetFaction = {GetFactionInfo(f)}
                                    if GetFaction[1] == Name then
                                        if GetFaction[11] then 
                                            return GetFaction[3];
                                        end
                                    end
                                end";
                results = Lua.LuaDoString<Int32>(Faction.Replace("Name", FactionName.Replace("'", "\'")));
            }
            catch (Exception ex)
            {
                Logging.WriteError($"Error : {ex}");
                results = 0;
            }
            return (FactionStandingRank)results;
        }
    }
}
