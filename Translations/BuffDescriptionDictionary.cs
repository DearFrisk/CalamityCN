﻿using System.Collections.Generic;

namespace CalamityCN
{
    public class BuffDescriptionDict
    {
        public static Dictionary<string, string> EffectDescription;
        public static void Load()
        {
            EffectDescription = new Dictionary<string, string>()
            {
                {"SeaSnailBuff", "喵？".zh()},
                {"AlcoholPoisoning", "你饮酒过量，代谢紊乱，气息奄奄".zh()},
                {"BloodyMaryBuff", "血月时伤害和移动速度增加，但生命再生速度和防御降低".zh()},
                {"CaribbeanRumBuff", "你晕乎乎的，增加移动速度、飞行时间和生命再生速度，但防御力降低".zh()},
                {"CinnamonRollBuff", "增加魔力恢复速度和火系减益的伤害，但防御力降低".zh()},
                {"EverclearBuff", "增加伤害，但降低防御力和生命再生速度".zh()},
                {"EvergreenGinBuff", "提高疫病系和水系减益的伤害并提高伤害减免，但降低生命再生速度".zh()},
                {"FabsolVodkaBuff", "你感受到了一种难以置信的美妙".zh()},
                {"FireballBuff", "提高火系减益伤害，但降低生命再生速度".zh()},
                {"GrapeBeerBuff", "防御降低".zh()},
                {"MargaritaBuff", "减少绝大部分减益的持续时间，但降低防御力和生命再生速度".zh()},
                {"MoonshineBuff", "增加防御力和伤害减免，但降低生命再生速度".zh()},
                {"MoscowMuleBuff", "增加伤害、暴击率和击退力，但降低生命再生速度".zh()},
                {"RedWineBuff", "降低生命再生速度".zh()},
                {"RumBuff", "增加移动速度和生命再生速度，但防御力降低".zh()},
                {"ScrewdriverBuff", "增加穿透弹幕伤害，但降低生命再生速度".zh()},
                {"StarBeamRyeBuff", "增加魔法伤害和最大魔力值、降低魔力消耗，但降低防御力和生命再生速度".zh()},
                {"TequilaBuff", "白天时暴击率、防御和击退增加，但生命再生速度降低".zh()},
                {"TequilaSunriseBuff", "白天时暴击率、防御和击退增加，但生命再生速度降低".zh()},
                {"Trippy", "你看到了世界的本质……同时增加50%伤害".zh()},
                {"VodkaBuff", "增加伤害和暴击率，但降低防御力和生命再生速度".zh()},
                {"WhiskeyBuff", "增加伤害、暴击率和击退力，但防御力降低".zh()},
                {"WhiteWineBuff", "提高魔法伤害，但降低防御力和生命再生速度".zh()},
                {"AstralInfectionDebuff", "你的血肉正在被幻星熔蚀".zh()},
                {"BrimstoneFlames", "生命快速流失".zh()},
                {"BurningBlood", "你的血液沸腾了".zh()},
                {"SearingLava", "硫火岩浆的烧灼难以承受".zh()},
                {"CrushDepth", "深海水压".zh()},
                {"GodSlayerInferno", "你的血肉在燃烧".zh()},
                {"HolyFlames", "神圣之光将你焚化".zh()},
                {"HolyInferno", "你离亵渎天神太远了！".zh()},
                {"Dragonfire", "生命流失，移动速度降低".zh()},
                {"Nightwither", "被月之射线瓦解".zh()},
                {"Plague", "从内部腐烂".zh()},
                {"Shadowflame", "失去生命".zh()},
                {"ShellfishClaps", "大快朵颐".zh()},
                {"Shred", "有人造了十把三尖匕首……".zh()},
                {"SnapClamDebuff", "扇贝轻夹".zh()},
                {"SulphuricPoisoning", "有毒的硫磺海水正在烧灼你的皮肤".zh()},
                {"Vaporfied", "蒸汽波是极美的".zh()},
                {"VulnerabilityHex", "你很虚弱".zh()},
                {"AlicornBuff", "你喝高了还打败了神长直，心朗气清，足以畅叙幽情！".zh()},
                {"BrimroseMount", "坐着温暖舒适。那就足够了".zh()},
                {"GazeOfCrysthamyrBuff", "你骑着一只暗影飞龙".zh()},
                {"OnyxExcavatorBuff", "钻钻钻！".zh()},
                {"SquishyBeanBuff", "BEAN MAN. BEAN DO T H E  B EA N IS HER E".zh()},
                {"RimehoundBuff", "你正驾驭着愤怒雪狗".zh()},
                {"AkatoBuff", "看起来你现在应该好好照顾这只小龙".zh()},
                {"AstrophageBuff", "小小的幻星机器".zh()},
                {"BabyGhostBellBuff", "小心不要戳破那个泡泡".zh()},
                {"BearBuff", "守护天使正在跟着你".zh()},
                {"BloodBound", "有它在身边陪伴，你一定很沮丧".zh()},
                {"BrimlingBuff", "保护她或迎接苦难的折磨，二选一".zh()},
                {"ChibiiDoGBuff", "什么？你期待还能召唤出谁？".zh()},
                {"DannyDevito", "垃圾男正在跟着你".zh()},
                {"FoxPetBuff", "狐狸宠物？\n狐 狸".zh()},
                {"FurtasticDuoBuff", "它们做到了！毛茸茸的伙伴们围在你周围".zh()},
                {"Kendra", "一位忠诚的朋友陪在你身旁".zh()},
                {"LeviBuff", "小而可爱".zh()},
                {"RadiatorBuff", "具放射性的可爱生物".zh()},
                {"ElectricTroublemaker", "闪电从不会两次击中同一个地方".zh()},
                {"ClassicSCalPetBuff", "至尊灾厄之力守护着你……真可爱".zh()},
                {"OceanSpiritBuff", "音轻体柔，小巧玲珑".zh()},
                {"ThirdSageBuff", "额，这不可能是鬼".zh()},
                {"CirrusBlueCandleBuff", "飘浮的火焰振奋着你的灵魂".zh()},
                {"ChaosCandleBuff", "蜡烛周围的刷怪率增加！".zh()},
                {"CorruptionEffigyBuff", "腐化之地的力量灌注双拳".zh()},
                {"CrimsonEffigyBuff", "猩红之地的力量充盈于身".zh()},
                {"CirrusPinkCandleBuff", "它耀眼的光芒给周围的人带来了希望".zh()},
                {"CirrusPurpleCandleBuff", "暴风骤雨也无法熄灭这不灭的火".zh()},
                {"TranquilityCandleBuff", "蜡烛周围的刷怪率降低！".zh()},
                {"CirrusYellowCandleBuff", "它那惹人厌的火光只会激起愤怒".zh()},
                {"PopoBuff", "你是个雪人了！".zh()},
                {"PopoNoselessBuff", "你的鼻子被别人偷走了！".zh()},
                {"AnechoicCoatingBuff", "深渊生物的探测范围缩小".zh()},
                {"AstralInjectionBuff", "大幅增加魔力值恢复速度".zh()},
                {"BaguetteBuff", "如果只有我知道……~醉仙女".zh()},
                {"BloodfinBoost", "不要让血液冲昏头脑".zh()},
                {"BoundingBuff", "提高跳跃高度和跳跃速度，增加摔落伤害减免".zh()},
                {"CalciumBuff", "免疫摔落伤害".zh()},
                {"CeaselessHunger", "你吸收着世界上所有的物品".zh()},
                {"GravityNormalizerBuff", "在太空中恢复正常重力作用，免疫扭曲减益".zh()},
                {"Omniscience", "你能看透世间万物".zh()},
                {"PhotosynthesisBuff", "增加生命再生速度，在白天时生命恢复更快，红心能回复更多生命值".zh()},
                {"Soaring", "增加飞行速度和飞行时间\n真近战攻击击中敌怪时恢复一定的飞行时间".zh()},
                {"TeslaBuff", "召唤一个电流光环".zh()},
                {"TitanScale", "你感觉可以坦住成年幻海妖龙".zh()},
                {"TriumphBuff", "降低敌怪的接触伤害，生命值越低，降低幅度越大".zh()},
                {"YharimPower", "你感觉可以把世界撕成了两半……空手足矣！".zh()},
                {"Zen", "大幅降低刷怪率".zh()},
                {"Zerg", "大幅提高刷怪率".zh()},
                {"AbyssalDivingSuitBuff", "你是铁打的".zh()},
                {"AbyssalDivingSuitPlates", "外壳金属会吸收15%的伤害".zh()},
                {"AbyssalMadness", "增加伤害和暴击率，提高深渊触手的攻击距离和攻击性".zh()},
                {"AdrenalineMode", "伤害提高200%。能使用其他物品提升至245%。".zh()},
                {"Afflicted", "被异界之魂祝福".zh()},
                {"AmidiasBlessing", "你被海神祝福了\n拥有水下呼吸的能力，在深渊中也生效！\n小心别受伤……".zh()},
                {"BloodflareBloodFrenzy", "降低怪物的接触伤害，大幅提高近战属性".zh()},
                {"BossEffects", "This tooltip is edited in the function below".zh()},
                {"ChiBuff", "你更有适应性".zh()},
                {"CosmicFreeze", "寒气逼人，犹如身于宙域".zh()},
                {"ElysianGuard", "移动速度降低，提高各项属性".zh()},
                {"Encased", "增加30点防御和30%伤害减免，但是……".zh()},
                {"GraxBoost", "提高防御力，你的肌肉更加强壮".zh()},
                {"IceShieldBuff", "受伤时吸收20%的伤害，随后破碎".zh()},
                {"Molten", "对寒冷效果具有抗性".zh()},
                {"Mushy", "增加防御力和生命再生速度".zh()},
                {"PolarisBuff", "北极星强化了你的生命再生".zh()},
                {"RageMode", "伤害提高35%".zh()},
                {"ReaverRage", "爷怒了".zh()},
                {"ShellBoost", "增加移动速度".zh()},
                {"SilvaRevival", "你处于无敌状态，免疫大多数减益".zh()},
                {"AquaticHeartBuff", "女装有趣吗？".zh()},
                {"AquaticHeartWaterSpeed", "增加15%移动速度和加速度".zh()},
                {"SpiritPower", "增加10%召唤伤害".zh()},
                {"SpiritDefense", "增加6点防御力和3%伤害减免".zh()},
                {"SpiritRegen", "恢复生命".zh()},
                {"TarragonCloak", "降低接触伤害".zh()},
                {"TarragonImmunity", "你现在无敌了".zh()},
                {"TarraLifeRegen", "极速生命恢复".zh()},
                {"TyrantsFury", "提高30%近战伤害和10%近战暴击率".zh()},
                {"EmpyreanRage", "宇宙的怒火".zh()},
                {"EmpyreanWrath", "宇宙的狂怒".zh()},
                {"ArmorCrunch", "你的护甲被撕裂了".zh()},
                {"Clamity", "远古巨蛤怒了！".zh()},
                {"Enraged", "所有受到的伤害增加25%".zh()},
                {"Eutrophication", "过多的营养物质拖慢了你的步伐".zh()},
                {"ExoFreeze", "无法移动".zh()},
                {"DoGExtremeGravity", "无限飞行失效，飞行时间减少25%".zh()},
                {"IcarusFolly", "飞行时间减少33%，无限飞行失效".zh()},
                {"FishAlert", "深渊生物发现你了！".zh()},
                {"FrozenLungs", "冰冷的水使你无法呼吸".zh()},
                {"GlacialState", "无法移动".zh()},
                {"Irradiated", "你的皮肤正被侵蚀".zh()},
                {"MarkedforDeath", "降低伤害减免".zh()},
                {"PearlAura", "减速".zh()},
                {"TemporalSadness", "蓝瘦香菇".zh()},
                {"TimeDistortion", "时间流逝减缓".zh()},
                {"Warped", "移动被空间翘曲影响".zh()},
                {"WeakPetrification", "弱化垂直移动能力".zh()},
                {"WhisperingDeath", "死亡临近；降低攻击力和生命再生速度".zh()},
                {"ValkyrieBuff", "天武神会保护你".zh()},
                {"AncientMineralSharkBuff", "来自远古，危险无比".zh()},
                {"AquaticStar", "深海之星会保护你".zh()},
                {"AbandonedSlimeBuff", "迷你末世星史莱姆会保护你".zh()},
                {"AstralProbeBuff", "幻星探测器会保护你".zh()},
                {"HydrothermicVentBuff", "沸腾渊泉会保护你".zh()},
                {"BlackHawkBuff", "喷气战斗机会保护你".zh()},
                {"BloodClot", "血块会保护你".zh()},
                {"BrimstoneWaifu", "硫磺火元素会保护你".zh()},
                {"BrittleStar", "脆弱海星会保护你".zh()},
                {"Calamari", "深渊乌贼会保护你".zh()},
                {"CloudyWaifu", "雨云元素会保护你".zh()},
                {"Corroslime", "腐化史莱姆会保护你".zh()},
                {"CosmicEnergy", "归虚之灵会保护你".zh()},
                {"CosmilampBuff", "宇宙之光照耀着你".zh()},
                {"Crimslime", "血腥史莱姆会保护你".zh()},
                {"DaedalusCrystalBuff", "代达罗斯水晶会保护你".zh()},
                {"DankCreeperBuff", "沼泽之眼会保护你".zh()},
                {"DemonshadeSetDevilBuff", "赤红恶魔与你同在".zh()},
                {"ElementalAxeBuff", "元素之斧会保护你".zh()},
                {"EndoCooperBuff", "寒古宙以来冰封的晶体为你而战".zh()},
                {"FungalClumpBuff", "真菌块会保护你".zh()},
                {"HermitCrab", "寄居蟹会保护你".zh()},
                {"Herring", "鲱鱼群会保护你".zh()},
                {"HotE", "所有元素之灵给予你祝福，为你而战".zh()},
                {"Mechworm", "星宇护卫在你身旁飞翔".zh()},
                {"Phantom", "噬魂幽花的灵魂碎片主动帮助你".zh()},
                {"PlantationBuff", "迷你世纪之花会保护你\n是你吗，世纪小花？".zh()},
                {"ProfanedBabs", "亵渎守卫全员将为你而战！".zh()},
                {"ResurrectionButterflyBuff", "回归于花下好了，春之亡灵！\n沉眠于花下好了，红白之蝶！".zh()},
                {"Sandnado", "沙龙卷会保护你".zh()},
                {"SandyHealingWaifu", "沙元素会治疗你".zh()},
                {"SandyWaifu", "沙元素会保护你".zh()},
                {"ShellfishBuff", "沉沦之贝会保护你".zh()},
                {"SilvaCrystalBuff", "始源林海水晶在你头顶闪耀".zh()},
                {"SiriusBuff", "有点亮，毕竟是颗蓝矮星".zh()},
                {"SolarSpirit", "太阳之灵会保护你".zh()},
                {"SolarGodSpiritBuff", "太阳神之灵会保护你".zh()},
                {"BabySlimeGodBuff", "史莱姆之神会保护你".zh()},
                {"WaterWaifu", "阿娜希塔会保护你".zh()},
                {"WulfrumDroidBuff", "钨钢无人机会保护你".zh()},
                {"FieryDraconidBuff", "炽焰天龙会保护你".zh()},
                {"FlakHermitBuff", "淘气的小酸虫".zh()},
                {"SparksBuff", "这东西吃蝴蝶".zh()},
                {"BrimflameFrenzyBuff", "以生命为代价，黑魔法大大增强了你的力量".zh()},
                {"HallowedRunePower", "召唤伤害增加10%".zh()},
                {"HallowedRuneDefense", "增加8点防御力和4%防御减免".zh()},
                {"HallowedRuneRegeneration", "恢复生命".zh()},
                {"ProfanedCrystalBuff", ""},
                {"BelladonnaSpiritBuff", "可爱的森林精灵正跟着你".zh()},
                {"SkeletalDragonsBuff", "幸福大家庭".zh()},
                {"CinderBlossomBuff", "一朵灼热的花儿在你头顶浮动".zh()},
                {"ColdDivinityBuff", "古老冰霜城堡的魔法会帮助你".zh()},
                {"CorvidHarbringerBuff", "强大的渡鸦会保护你".zh()},
                {"CosmicViperEngineBuff", "宇宙武装战机会保护你".zh()},
                {"DazzlingStabberBuff", "时刻戒护".zh()},
                {"BrimseekerBuff", "它是不是想从你身上索取些什么？".zh()},
                {"EndoHydraBuff", "冰洋九头蛇将保护你……出于某些原因".zh()},
                {"FrostBlossomBuff", "一朵冰冷的花在你头顶浮动".zh()},
                {"MiniPlaguebringerBuff", "一只小瘟疫蜂跟着你".zh()},
                {"HauntedDishesBuff", "缠怨鬼碟会保护你".zh()},
                {"IgneousExaltationBuff", "淬焰古刀围绕着你旋转".zh()},
                {"MagicHatBuff", "我会一直留着你的灵魂当人质，但你找到的东西都得留下！".zh()},
                {"MidnightSunBuff", "一个奇怪的UFO在观察你，这令你很不舒服".zh()},
                {"MiniOldDukeBuff", "年轻的硫海公爵保护你".zh()},
                {"ViriliBuff", "很遗憾你不能拥抱她".zh()},
                {"SarosPossessionBuff", "闪熠的流光日环保护着你".zh()},
                {"BabyBloodCrawlerBuff", "血爬虫宝宝将保护你".zh()},
                {"SmallSkeletonBuff", "骷髅在注视着你".zh()},
                {"BabyStormlionBuff", "风暴蚁狮宝宝将保护你".zh()},
                {"TacticalPlagueEngineBuff", "一架瘟疫喷气战机跟着你".zh()},
                {"VileFeederBuff", "灵魂吞噬者宝宝将保护你".zh()},
                {"PlaguebringerBabBuff", "瘟疫使者宝宝将你视为它们的女王".zh()},
                {"EffigyOfDecayBuff", "硫海之水给予你力量".zh()},
                {"SulphurskinBuff", "削弱硫海之水对你的影响".zh()},
                {"GammaHydraBuff", "……".zh()},
                {"LadBuff", "啊哈哈哈，你爹来咯".zh()},
                {"ProfanedWeakness", "你造成的伤害降低".zh()},
                {"TundraFlameBlossomsBuff", "均衡与美丽的完美和谐".zh()},
                {"AndromedaBuff", "你操控之物本已成为历史".zh()},
                {"AndromedaSmallBuff", "你操控之物本已成为历史".zh()},
                {"BumbledogeMount", "你骑在癫痫鸟上……不对劲".zh()},
                {"Dreamfog", "祂相信伱".zh()},
                {"ShadowBuff", "你隐形了，某些盗贼武器会使你获得增益，提高盗贼潜行值恢复速度。".zh()},
                {"BloodyBoost", "增强攻击和防御属性\n治疗药水回复更多生命值".zh()},
                {"KamiBuff", "提高伤害和移动速度".zh()},
                {"AndromedaCripple", "你变慢了".zh()},
                {"KamiFlu", "手无寸铁，奄奄一息".zh()},
                {"CausticStaffBuff", "迷你丛林之龙正在跟着你".zh()},
                {"GastricAberrationBuff", "深海吞食者会保护你".zh()},
                {"HowlTrio", "哈尔会保护你，卡西法会照亮你的道路，小萝卜头会跟随着你".zh()},
                {"MountedScannerBuff", "强大的机械环绕在你的身边".zh()},
                {"LilPlaguebringerBuff", "瘟疫使者会保护你".zh()},
                {"PoleWarperBuff", "你吸引着这些磁场模块".zh()},
                {"SnakeEyesBuff", "永远注视着……".zh()},
                {"StarSwallowerBuff", "并不能吞噬星星".zh()},
                {"Withered", "手持凋零的武器会让你渐渐枯萎，但也会让你的武器变得强大".zh()},
                {"BanishingFire", "你的罪孽不会被宽赦".zh()},
                {"ManaBurn", "过多的魔力正在烧蚀你的身心".zh()},
                {"SagePoison", "中毒".zh()},
                {"WeakBrimstoneFlames", "生命流失".zh()},
                {"TheCartofGodsBuff", "驾驭星宇所恐惧之物".zh()},
                {"DraedonGamerChairBuff", "坐在一把挑战物理的游戏椅上".zh()},
                {"ArcherofLunamoon", "现在你有了属于自己的观察员".zh()},
                {"MiniMindBuff", "它知晓一切".zh()},
                {"LittleLightBuff", "小东西长得真别致".zh()},
                {"PineappleBuff", "它闻起来像披萨……".zh()},
                {"ReaverOrbBuff", "掠夺者宝珠会照亮你的前路".zh()},
                {"AvertorBonus", "增加伤害与生命再生速度".zh()},
                {"DivineBless", "增加生命再生速度，召唤物攻击会造成放逐之火减益".zh()},
                {"PhantomicShield", "增加10点防御，提升5%伤害减免\n幻魂壁垒保护着你".zh()},
                {"PhantomicEmpowerment", "提升10%召唤伤害".zh()},
                {"PhantomicRegen", "生命再生".zh()},
                {"WitherDebuff", "枯萎了……\n减少20点防御力".zh()},
                {"DaedalusGolemBuff", "一个水晶傀儡正在跟随你".zh()},
                {"MiniatureEyeofCthulhu", "它正在注视你".zh()},
                {"EyeOfNightBuff", "它诡异地注视着一切".zh()},
                {"FleshBallBuff", "为什么这玩意在跟着你？".zh()},
                {"FlowersOfMortalityBuff", "天界之花环绕着你".zh()},
                {"PerditionBuff", "永劫不复".zh()},
                {"SageSpiritBuff", "靠的太近了，很不舒服".zh()},
                {"SepulcherMinionBuff", "它并非带着善意而来……".zh()},
                {"SoulSeekerBuff", "它渴望汝所拥有之物……".zh()},
                {"ViridVanguardBuff", "你身边环绕着完美的和谐之风".zh()},
                {"VoidConcentrationBuff", "无尽之虚空渴望着更多……".zh()},
                {"WitherBlossomsBuff", "瘟疫之蕾环绕在你身边".zh()},
                {"YharonSonBuff", "你最好别不小心把他的晚餐吃了".zh()},
                {"RancorBurn", "燃烧".zh()},
                {"IceClasperBuff", "食魂冰虫会保护你".zh()},
                {"EntropysVigilBuff", "灾厄之影和她的兄弟们会保护你".zh()},
                {"CoralSymbiosis", "珊瑚泥充能加快，多造成2点伤害".zh() },
                {"MarniteLiftBuff", "你甚至……？".zh() },
                {"PuffWarriorBuff", "它自信且兴奋地保护着你".zh() },
                {"MoonFistBuff", "准备好用这些手去打一架了吗？".zh() },
                {"ExoskeletonCannons", "内不含脉冲加农".zh() },

                {"MiracleBlight", "星流共振撕碎了组成你身体的物质".zh()},
                {"EidolonSnailBuff", "多么愚蠢的史前小蜗牛".zh()},
                {"GoldieBuff", "闪光的都是金子".zh()},
                {"WeaponImbueBrimstone", "近战、鞭子和盗贼攻击会造成硫磺火减益".zh()},
                {"WeaponImbueCrumbling", "近战、鞭子和盗贼攻击会对敌人造成碎甲减益".zh()},
                {"WeaponImbueHolyFlames", "近战、鞭子和盗贼攻击会造成神圣之火减益".zh()},
                {"ChiRegenBuff", "生命再生速度增加".zh()},
                {"GalvanicCorrosion", "你的四肢正被腐蚀".zh()},
            };
        }
        public static void Unload()
        {
            EffectDescription = null;
        }
    }
}
