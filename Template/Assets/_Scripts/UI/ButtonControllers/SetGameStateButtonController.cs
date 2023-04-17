using Util.Enums;
using Util.Systems;
using Util.UI.Controllers.Selectables.Buttons;

namespace Template.UI.ButtonControllers
{
    public class SetGameStateButtonController : AButtonController
    {
        public GameState TargetGameState;
    
        public override void OnClick()
        {
            GameSystem.Instance.ChangeGameState(TargetGameState);
        }
    }
}