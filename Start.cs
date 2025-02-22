using HarmonyLib;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class ReasonableAdvancedCollectionNets : Mod
{
    public void Start()
    {
		var netItem = ItemManager.GetItemByName("Placeable_CollectionNet_Advanced");
		
        netItem.settings_recipe.NewCost = new CostMultiple[] { 
			new CostMultiple(new Item_Base[] { ItemManager.GetItemByName("Plank") }, 9),
			new CostMultiple(new Item_Base[] { ItemManager.GetItemByName("Rope") }, 10),
			new CostMultiple(new Item_Base[] { ItemManager.GetItemByName("MetalIngot") }, 3),
		};

        Debug.Log("[Reasonable Advanced Collection Nets] Mod has been loaded!");
    }

}