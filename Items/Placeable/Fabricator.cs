using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace NauticaMod.Items.Placeable
{
	public class Fabricator : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Atomically rearranges raw resources into useful objects.");
		}

		public override void SetDefaults() {
			item.width = 21;
			item.height = 32;
			item.maxStack = 20;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 150;
			item.createTile = TileType<Tiles.Fabricator>();
		}

		/*public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(ItemType<ExampleBlock>(), 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
	}
}