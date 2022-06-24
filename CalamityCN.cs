using Terraria.ModLoader;
using Terraria.Localization;

namespace CalamityCN
{
	public class CalamityCN : Mod
	{
        public CalamityCN()
        {

        }
        public override void PostSetupContent()
        {
            if (ModLoader.TryGetMod("CalamityMod", out Mod Calamity))
            {

                /*
                    �X�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�[
                    �U +-+ | ������� | +-+ �U
                    �^�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�a
                */

                ItemNameDict itemNameDictionary = new ItemNameDict();
                ItemToolTipDict itemTooltipDictionary = new ItemToolTipDict();
                NPCNameDict npcNameDictionary = new NPCNameDict();
                BuffNameDict buffNameDictionary = new BuffNameDict();
                BuffDescriptionDict buffDescriptionDictionary = new BuffDescriptionDict();

                /*
                    �X�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�[
                    �U +-+ | ��Ʒ | +-+ �U
                    �^�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�a
                */

                //��Ʒ����
                foreach (var itemName in itemNameDictionary.ItemName)
                {
                    Calamity.Find<ModItem>(itemName.Key).DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, itemName.Value);
                }

                //��Ʒ˵��
                foreach (var itemTooltip in itemTooltipDictionary.ItemToolTip)
                {
                    Calamity.Find<ModItem>(itemTooltip.Key).Tooltip.AddTranslation((int)GameCulture.CultureName.Chinese, itemTooltip.Value);
                }
                /*
                    �X�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�[
                    �U +-+ | �������   | +-+ �U
                    �^�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�a
                */

                //Buff����
                foreach (var effectName in buffNameDictionary.EffectName)
                {
                    Calamity.Find<ModBuff>(effectName.Key).DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, effectName.Value);
                }

                //Buff˵��
                foreach (var effectDescription in buffDescriptionDictionary.EffectDescription)
                {
                    Calamity.Find<ModBuff>(effectDescription.Key).Description.AddTranslation((int)GameCulture.CultureName.Chinese, effectDescription.Value);
                }
                /*
                    �X�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�[
                    �U +-+ | NPC | +-+ �U
                    �^�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�T�a
                */

                //NPC����
                foreach (var npcName in npcNameDictionary.NPCName)
                {
                    Calamity.Find<ModNPC>(npcName.Key).DisplayName.AddTranslation(7, npcName.Value);
                }
            }
        }
    }
}