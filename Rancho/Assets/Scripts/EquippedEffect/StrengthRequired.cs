using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class StrengthRequired : EquipmentItem.EquippedEffect
{
    public StatSystem.StatModifier Modifier;
    public int strRequirement;

    public override void Equipped(CharacterData user)
     {
        if (user.Stats.baseStats.strength >= strRequirement)
        {
            user.Stats.AddModifier(Modifier);
        }
    }
     
     public override void Removed(CharacterData user)
     {
        user.Stats.RemoveModifier(Modifier);
    }

    public override string GetDescription()
    {
        string desc = base.GetDescription() + "\n";

        string unit = Modifier.ModifierMode == StatSystem.StatModifier.Mode.Percentage ? "%" : "";

        if (Modifier.Stats.strength != 0)
            desc += $"Str : {Modifier.Stats.strength:+0;-#}{unit}\n"; //format specifier to force the + sign to appear
        if (Modifier.Stats.agility != 0)
            desc += $"Agi : {Modifier.Stats.agility:+0;-#}{unit}\n";
        if (Modifier.Stats.defense != 0)
            desc += $"Def : {Modifier.Stats.defense:+0;-#}{unit}\n";
        if (Modifier.Stats.health != 0)
            desc += $"HP : {Modifier.Stats.health:+0;-#}{unit}\n";


        return desc;
    }
}
