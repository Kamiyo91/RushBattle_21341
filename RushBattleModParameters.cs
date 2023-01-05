using System.Collections.Generic;
using BigDLL4221.Models;
using BigDLL4221.StageManagers;
using GlitchedMod;
using KamiyoModPack.BLL_Re21341.Models;
using Mary_Ib21341.BLL;
using OmoriMod_Om21341.BLL_Om21341;
using Purple_V21341.BLL;
using VortexTower;

namespace RushBattle_21341
{
    public static class RushBattleModParameters
    {
        public static readonly RushBattlePhaseOptions Phase1 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.OldSamurai },
            new Dictionary<string, List<MapModel>>
                { { KamiyoModParameters.PackageId, new List<MapModel> { KamiyoModParameters.SamuraiMapPlayer } } }, unitAllowed: 1,
            cmhPackageId: KamiyoModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase2 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.Mio },
            new Dictionary<string, List<MapModel>>
                { { KamiyoModParameters.PackageId, new List<MapModel> { KamiyoModParameters.MioMap } } }, unitAllowed: 3,
            cmhPackageId: KamiyoModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase3 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.Kamiyo },
            new Dictionary<string, List<MapModel>>
                { { KamiyoModParameters.PackageId, new List<MapModel> { KamiyoModParameters.KamiyoMap1,KamiyoModParameters.KamiyoMap2 } } }, unitAllowed: 4,
            cmhPackageId: KamiyoModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase4 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.Hayate },
            new Dictionary<string, List<MapModel>>
                { { KamiyoModParameters.PackageId, new List<MapModel> { KamiyoModParameters.HayateMap } } }, unitAllowed: 1,
            cmhPackageId: KamiyoModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase5 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.Wilton },
            new Dictionary<string, List<MapModel>>
                { { KamiyoModParameters.PackageId, new List<MapModel> { KamiyoModParameters.WiltonMap } } }, unitAllowed: 2,
            cmhPackageId: KamiyoModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase6 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.Raziel },
            new Dictionary<string, List<MapModel>>
                { { KamiyoModParameters.PackageId, new List<MapModel> { KamiyoModParameters.RazielMap } } }, unitAllowed: 4,
            cmhPackageId: KamiyoModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase7 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.Sae, UnitModels.VortexGuard, UnitModels.VortexGuard },
            new Dictionary<string, List<MapModel>>
                { { VortexModParameters.PackageId, new List<MapModel> { VortexModParameters.SaePhase1Map ,VortexModParameters.SaePhase2Map } } }, formationId: 41,unitAllowed:1,
            cmhPackageId: VortexModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase8 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.Miyu, UnitModels.AztecPriest, UnitModels.AztecPriest },
            new Dictionary<string, List<MapModel>>
                { { VortexModParameters.PackageId, new List<MapModel> { VortexModParameters.MiyuMap } } }, formationId: 41, unitAllowed: 2,
            cmhPackageId: VortexModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase9 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.GreenHunter },
            new Dictionary<string, List<MapModel>>
                { { VortexModParameters.PackageId, new List<MapModel> { VortexModParameters.ZeroMap } } }, unitAllowed: 3,
            cmhPackageId: VortexModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase10 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.SoulPiece },
            new Dictionary<string, List<MapModel>>
            {
                {
                    VortexModParameters.PackageId, new List<MapModel>
                    {
                        VortexModParameters.ForgottenMap1,
                        VortexModParameters.ForgottenMap2,
                        VortexModParameters.ForgottenMap3,
                        VortexModParameters.ForgottenMap4,
                        VortexModParameters.ForgottenMap5
                    }
                }
            }, unitAllowed: 4, cmhPackageId: VortexModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase11 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.Finn, UnitModels.Jake },
            new Dictionary<string, List<MapModel>>
            {
                { GlitchedModParameters.PackageId, new List<MapModel> { GlitchedModParameters.GlitchedDuoMapModel } }
            }, unitAllowed: 2, cmhPackageId: GlitchedModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase12 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.Peter },
            new Dictionary<string, List<MapModel>>
            {
                { GlitchedModParameters.PackageId, new List<MapModel> { GlitchedModParameters.GlitchedPeterMapModel } }
            }, unitAllowed: 3, cmhPackageId: GlitchedModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase13 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.PurplePoison },
            new Dictionary<string, List<MapModel>>
                { { PurpleModParameters.PackageId, new List<MapModel> { MapModels.PurplePoisonMap } } }, starterMapPhase:-1, unitAllowed: 3,
            cmhPackageId: PurpleModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase14 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.Omori },
            new Dictionary<string, List<MapModel>>
            {
                {
                    OmoriModParameters.PackageId, new List<MapModel>
                    {
                        OmoriModParameters.OmoriMap1,
                        OmoriModParameters.OmoriMap2,
                        OmoriModParameters.OmoriMap3,
                        OmoriModParameters.OmoriMap4,
                        OmoriModParameters.OmoriMap5
                    }
                }
            }, unitAllowed: 4, cmhPackageId: OmoriModParameters.PackageId);

        public static readonly RushBattlePhaseOptions Phase15 = new RushBattlePhaseOptions(
            new List<UnitModel> { UnitModels.Mary },
            new Dictionary<string, List<MapModel>>
                { { MaryModParameters.PackageId, new List<MapModel> { MaryModParameters.MaryMapModel } } }, unitAllowed: 3,
            cmhPackageId: MaryModParameters.PackageId);
    }

    public static class UnitModels
    {
        //ModPack
        public static readonly UnitModel OldSamurai = new UnitModel(1, KamiyoModParameters.PackageId, 1);
        public static readonly UnitModel Mio = new UnitModel(3, KamiyoModParameters.PackageId, 3);
        public static readonly UnitModel Kamiyo = new UnitModel(4, KamiyoModParameters.PackageId, 4);
        public static readonly UnitModel Hayate = new UnitModel(6, KamiyoModParameters.PackageId, 6);
        public static readonly UnitModel Wilton = new UnitModel(8, KamiyoModParameters.PackageId, 8);
        public static readonly UnitModel Raziel = new UnitModel(10, KamiyoModParameters.PackageId, 10);

        //Vortex
        public static readonly UnitModel VortexGuard = new UnitModel(1, VortexModParameters.PackageId, 1);
        public static readonly UnitModel Sae = new UnitModel(2, VortexModParameters.PackageId, 2);
        public static readonly UnitModel AztecPriest = new UnitModel(3, VortexModParameters.PackageId, 3);
        public static readonly UnitModel Miyu = new UnitModel(4, VortexModParameters.PackageId, 4);
        public static readonly UnitModel GreenHunter = new UnitModel(5, VortexModParameters.PackageId, 5);
        public static readonly UnitModel SoulPiece = new UnitModel(6, VortexModParameters.PackageId, 6);

        //Glitched
        public static readonly UnitModel Finn = new UnitModel(1, GlitchedModParameters.PackageId, 1);
        public static readonly UnitModel Jake = new UnitModel(2, GlitchedModParameters.PackageId, 2);
        public static readonly UnitModel Peter = new UnitModel(3, GlitchedModParameters.PackageId, 3);

        //PurplePoison
        public static readonly UnitModel PurplePoison = new UnitModel(1, PurpleModParameters.PackageId, 1);

        //Omori
        public static readonly UnitModel Omori = new UnitModel(12, OmoriModParameters.PackageId, 12);

        //Mary
        public static readonly UnitModel Mary = new UnitModel(1, MaryModParameters.PackageId, 1);
    }
}