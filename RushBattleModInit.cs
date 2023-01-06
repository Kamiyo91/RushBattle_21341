using System.Collections.Generic;
using BigDLL4221.Enum;
using BigDLL4221.Models;
using BigDLL4221.Utils;

namespace RushBattle_21341
{
    public class RushBattleModInit : ModInitializer
    {
        public override void OnInitializeMod()
        {
            GenericUtil.PutModInTheLastSlot("RushBattle21341.Mod");
            ModParameters.ExtraOptions.Add("RushBattle21341.Mod", new List<ExtraOptions>
            {
                new ExtraOptions(1, optionType: ParameterTypeEnum.Stage
                    , bools: RushBattleModParameters.Bools,
                    ints: RushBattleModParameters.Ints,
                    unitModels: RushBattleModParameters.Units),
                new ExtraOptions(2, optionType: ParameterTypeEnum.Stage
                    , bools: RushBattleModParameters.Bools,
                    ints: RushBattleModParameters.Ints,
                    unitModels: RushBattleModParameters.Units)
            });
        }
    }
}