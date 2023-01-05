using System.Collections.Generic;
using BigDLL4221.StageManagers;

namespace RushBattle_21341
{
    public class EnemyTeamStageManager_RushBattle_21341 : EnemyTeamStageManager_RushBattleWithCMUOnly_DLL4221
    {
        public override void OnWaveStart()
        {
            SetParameter(new List<RushBattlePhaseOptions>
            {
                RushBattleModParameters.Phase1,
                RushBattleModParameters.Phase2,
                RushBattleModParameters.Phase3,
                RushBattleModParameters.Phase4,
                RushBattleModParameters.Phase5,
                RushBattleModParameters.Phase6,
                RushBattleModParameters.Phase7,
                RushBattleModParameters.Phase8,
                RushBattleModParameters.Phase9,
                RushBattleModParameters.Phase10,
                RushBattleModParameters.Phase11,
                RushBattleModParameters.Phase12,
                RushBattleModParameters.Phase13,
                RushBattleModParameters.Phase14,
                RushBattleModParameters.Phase15
            }, true, true);
            base.OnWaveStart();
        }
    }
}