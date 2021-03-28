using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace Heritage
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            if (game.GameType is Campaign)
            {
                Utils.Print("Hello from Heritage Logger :) We are in campaign mode");

                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarter;

                campaignStarter.AddBehavior(new HeritageBehavior());
                campaignStarter.AddBehavior(new HeroFixBehavior());
                campaignStarter.AddBehavior(new MarriageFixBehavior());
            }
        }
    }
}