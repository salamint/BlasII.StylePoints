using HarmonyLib;
using Il2CppTGK.Game.Components;

namespace BlasII.StylePoints.Patches;


[HarmonyPatch(typeof(PlayerExecutableKill), nameof(PlayerExecutableKill.StartExecution))]
class PlayerExecutableKill_StartExecution_Patch
{
	private static void Postfix(PlayerExecutableKill __instance)
	{
		Main.StylePoints.ComboMeter.Timer.Pause();
	}
}


[HarmonyPatch(typeof(PlayerExecutableKill), nameof(PlayerExecutableKill.FinishGenericExecution))]
class PlayerExecutableKill_FinishGenericExecution_Patch
{
	private static void Postfix(PlayerExecutableKill __instance)
	{
		Main.StylePoints.ComboMeter.Timer.Resume();
		Main.StylePoints.ComboMeter.Timer.Fill();
		Main.StylePoints.ComboMeter.Increment();
	}
}

