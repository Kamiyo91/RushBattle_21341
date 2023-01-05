using System.Collections.Generic;
using BigDLL4221.Enum;
using BigDLL4221.Models;

namespace RushBattle_21341
{
    public class RushBattleModInit : ModInitializer
    {
        public override void OnInitializeMod()
        {
            ModParameters.ExtraOptions.Add("RushBattle21341.Mod", new List<ExtraOptions>
            {
                new ExtraOptions(1, optionType: ParameterTypeEnum.Stage
                    , bools: new Dictionary<string, bool>
                    {
                        { Condition.RandomWave, true },
                        { Condition.HidePreview, true }
                    },
                    ints: new Dictionary<string, List<int>>
                    {
                        {$"{Condition.UsableUnits}0",new List<int>{1}},
                        {$"{Condition.FormationId}0",new List<int>{1}},
                        {$"{Condition.UsableUnits}1",new List<int>{3}},
                        {$"{Condition.FormationId}1",new List<int>{1}},
                        {$"{Condition.UsableUnits}2",new List<int>{4}},
                        {$"{Condition.FormationId}2",new List<int>{1}},
                        {$"{Condition.UsableUnits}3",new List<int>{1}},
                        {$"{Condition.FormationId}3",new List<int>{1}},
                        {$"{Condition.UsableUnits}4",new List<int>{2}},
                        {$"{Condition.FormationId}4",new List<int>{1}},
                        {$"{Condition.UsableUnits}5",new List<int>{4}},
                        {$"{Condition.FormationId}5",new List<int>{1}},
                        {$"{Condition.UsableUnits}6",new List<int>{1}},
                        {$"{Condition.FormationId}6",new List<int>{41}},
                        {$"{Condition.UsableUnits}7",new List<int>{2}},
                        {$"{Condition.FormationId}7",new List<int>{41}},
                        {$"{Condition.UsableUnits}8",new List<int>{3}},
                        {$"{Condition.FormationId}8",new List<int>{1}},
                        {$"{Condition.UsableUnits}9",new List<int>{4}},
                        {$"{Condition.FormationId}9",new List<int>{1}},
                        {$"{Condition.UsableUnits}10",new List<int>{2}},
                        {$"{Condition.FormationId}10",new List<int>{1}},
                        {$"{Condition.UsableUnits}11",new List<int>{3}},
                        {$"{Condition.FormationId}11",new List<int>{1}},
                        {$"{Condition.UsableUnits}12",new List<int>{3}},
                        {$"{Condition.FormationId}12",new List<int>{1}},
                        {$"{Condition.UsableUnits}13",new List<int>{4}},
                        {$"{Condition.FormationId}13",new List<int>{1}},
                        {$"{Condition.UsableUnits}14",new List<int>{2}},
                        {$"{Condition.FormationId}14",new List<int>{1}}

                    },
                    unitModels: new Dictionary<string, List<UnitModel>>
                    {
                        { "0", new List<UnitModel> { UnitModels.OldSamurai } },
                        { "1", new List<UnitModel> { UnitModels.Mio } },
                        { "2", new List<UnitModel> { UnitModels.Kamiyo } },
                        { "3", new List<UnitModel> { UnitModels.Hayate } },
                        { "4", new List<UnitModel> { UnitModels.Wilton } },
                        { "5", new List<UnitModel> { UnitModels.Raziel } },
                        { "6", new List<UnitModel> { UnitModels.Sae, UnitModels.VortexGuard, UnitModels.VortexGuard } },
                        {
                            "7", new List<UnitModel> { UnitModels.Miyu, UnitModels.AztecPriest, UnitModels.AztecPriest }
                        },
                        { "8", new List<UnitModel> { UnitModels.GreenHunter } },
                        { "9", new List<UnitModel> { UnitModels.SoulPiece } },
                        { "10", new List<UnitModel> { UnitModels.Finn, UnitModels.Jake } },
                        { "11", new List<UnitModel> { UnitModels.Peter } },
                        { "12", new List<UnitModel> { UnitModels.PurplePoison } },
                        { "13", new List<UnitModel> { UnitModels.Omori } },
                        { "14", new List<UnitModel> { UnitModels.Mary } }
                    })
            });
        }
    }
}