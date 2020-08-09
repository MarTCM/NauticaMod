using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace NauticaMod.Items 
{
	public class Bladderfish : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Unique outer membrane has potential as a natural water filter.");
		}
		public override void SetDefaults() {
			item.width = 33;
			item.height = 35;
			item.maxStack = 99;
			item.rare = ItemRarityID.Green;
			item.consumable = true;
            item.healLife = 15;
            item.UseSound = SoundID.Item2;
            item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 17;
			item.useTime = 17;
            item.potion = true; 
		}

	}
}