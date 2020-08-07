using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace NauticaMod.Items 
{
	public class Titanium : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Basic building material.");
		}
		public override void SetDefaults() {
			item.width = 16;
			item.height = 16;
			item.maxStack = 99;
			item.rare = ItemRarityID.White;
			item.consumable = false;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("MetalSalvage"), 1);
			recipe.AddTile(ModContent.TileType<Tiles.Fabricator>());
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}