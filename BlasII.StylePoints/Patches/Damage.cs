using HarmonyLib;
using Il2CppTGK.Game.Components.Attack.Data;
using Il2CppTGK.Game.Components.DamageEffects;

namespace BlasII.StylePoints.Patches;


[HarmonyPatch(typeof(DamageEffect), nameof(DamageEffect.OnHitReceived))]
class AttackReceiverComponent_ApplyInvincibilityTime_Hit_Patch
{
	private static AttackInfo lastAttack = null;

	private static void Postfix(DamageEffect __instance, AttackInfo arg0)
	{
		if (lastAttack == null || lastAttack != arg0)
		{
			Main.StylePoints.ComboMeter.Reset();
		}
	}
}

