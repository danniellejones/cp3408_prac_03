using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using Mono.Cecil;

public class PowerUp : UsableItem.UsageEffect
{
    public StatSystem.StatModifier PowerIncrease = new StatSystem.StatModifier();

    public override bool Use(CharacterData user)
    {
        user.Stats.AddModifier(PowerIncrease);
        return true;
    }
}
