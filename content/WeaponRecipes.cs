using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ReTerraria.Content
{
    public class WeaponRecipes : ModSystem
    {
        public override void PostAddRecipes()
        {
            int[] targetItems = new int[]
            {
                ItemID.DayBreak,
                ItemID.SolarEruption,
                ItemID.Phantasm,
                ItemID.VortexBeater,
                ItemID.NebulaArcanum,
                ItemID.NebulaBlaze,
                ItemID.StardustCellStaff,
                ItemID.StardustDragonStaff
            };

            // Remove existing recipies for items above
            foreach (Recipe recipe in Main.recipe)
            {
                if (recipe != null && System.Array.IndexOf(targetItems, recipe.createItem.type) != -1)
                {
                    recipe.DisableRecipe();
                }
            }

            AddCustomWeaponRecipes();
        }

        private void AddCustomWeaponRecipes()
        {
            // Daybreak: 18 Solar Fragment + Dark Lance
            Recipe.Create(ItemID.DayBreak)
                .AddIngredient(ItemID.FragmentSolar, 18)
                .AddIngredient(274)
                .AddTile(TileID.LunarCraftingStation)
                .Register();

            // Solar Eruption: 18 Solar Fragment + Sunfury
            Recipe.Create(ItemID.SolarEruption)
                .AddIngredient(ItemID.FragmentSolar, 18)
                .AddIngredient(220)
                .AddTile(TileID.LunarCraftingStation)
                .Register();

            // Phantasm: 18 Vortex Fragment + Hellwing Bow
            Recipe.Create(ItemID.Phantasm)
                .AddIngredient(ItemID.FragmentVortex, 18)
                .AddIngredient(3019)
                .AddTile(TileID.LunarCraftingStation)
                .Register();

            // Vortex Beater: 18 Vortex Fragment + Phoenix Blaster
            Recipe.Create(ItemID.VortexBeater)
                .AddIngredient(ItemID.FragmentVortex, 18)
                .AddIngredient(219)
                .AddTile(TileID.LunarCraftingStation)
                .Register();

            // Nebula Arcanum: 18 Nebula Fragment + Water Bolt
            Recipe.Create(ItemID.NebulaArcanum)
                .AddIngredient(ItemID.FragmentNebula, 18)
                .AddIngredient(ItemID.WaterBolt)
                .AddTile(TileID.LunarCraftingStation)
                .Register();

            // Nebula Blaze: 18 Nebula Fragment + Flamelash
            Recipe.Create(ItemID.NebulaBlaze)
                .AddIngredient(ItemID.FragmentNebula, 18)
                .AddIngredient(218)
                .AddTile(TileID.LunarCraftingStation)
                .Register();

            // Stardust Cell Staff: 18 Stardust Fragment + Imp Staff
            Recipe.Create(ItemID.StardustCellStaff)
                .AddIngredient(ItemID.FragmentStardust, 18)
                .AddIngredient(2365)
                .AddTile(TileID.LunarCraftingStation)
                .Register();

            // Stardust Dragon Staff: 18 Stardust Fragment + Abigail's Flower
            Recipe.Create(ItemID.StardustDragonStaff)
                .AddIngredient(ItemID.FragmentStardust, 18)
                .AddIngredient(5114)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}