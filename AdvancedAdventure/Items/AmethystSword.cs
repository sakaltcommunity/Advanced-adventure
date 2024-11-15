using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedAdventure.Items
{
    public class AmethystShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("アメジストショートソード");
            Tooltip.SetDefault("アメジストで作られた素早いショートソード。");
        }

        public override void SetDefaults()
        {
            Item.damage = 12; // 攻撃力
            Item.DamageType = DamageClass.Melee; // 近接攻撃
            Item.width = 30;
            Item.height = 30;
            Item.useTime = 15; // 使用間隔 (速さfast)
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Thrust; // 突き刺し攻撃
            Item.knockBack = 3; // ノックバック
            Item.value = Item.buyPrice(silver: 25); // 価格
            Item.rare = ItemRarityID.Blue; // レア度
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = false; // 連続攻撃不可

            // テクスチャを指定
            Item.SetDefaultTexture("AdvancedAdventure/Textures/Items/AmethystShortsword");
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Amethyst, 8); // 必要材料
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(TileID.Anvils); // 作業台
            recipe.Register();
        }
    }
}
