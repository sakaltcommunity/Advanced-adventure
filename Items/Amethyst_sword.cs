using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedAdventure.Items
{
    public class AmethystSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("アメジストの剣");
            Tooltip.SetDefault("アメジストで作られた強力な剣です。");
        }

        public override void SetDefaults()
        {
            Item.damage = 22; // 攻撃力
            Item.DamageType = DamageClass.Melee; // 近接攻撃
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20; // 使用間隔
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing; // 振り回し攻撃
            Item.knockBack = 5; // ノックバック
            Item.value = Item.buyPrice(silver: 50); // 価格
            Item.rare = ItemRarityID.Blue; // レア度
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true; // 自動連続攻撃
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Amethyst, 10); // 必要材料
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.Anvils); // 作業台
            recipe.Register();
        }
    }
}
