using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace NauticaMod.Items 
{
	public class MetalSalvage : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Composed primarily of titanium.");
		}
		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.maxStack = 99;
			item.rare = ItemRarityID.White;
			item.consumable = false;
		}

	}
}