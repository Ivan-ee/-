using System.Collections;
using System.Collections.Generic;
using GameDevTV.Core.UI.Tooltips;
using UnityEngine;

public class QuestTipSpawner : TooltipSpawner
{
    public override void UpdateTooltip(GameObject tooltip)
    {
    }

    public override bool CanCreateTooltip()
    {
        return true;
    }
}
