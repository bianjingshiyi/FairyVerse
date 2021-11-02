using UnityEngine;
namespace FairyVerse
{
    public class GameUICtrl : GameObjectCtrl<GameSceneCtrl>
    {
        #region 私有方法
        #region 生命周期
        protected override void Awake()
        {
            base.Awake();
            _escMenuUI.gameObject.SetActive(false);
            _ui.OnClickMenuButton += OnClickMenuButton;
            _escMenuUI.OnClickReturnToGameButton += OnClickEscMenuReturnToGameButton;
            _escMenuUI.OnClickReturnToMenuButton += OnClickEscMenuReturnToMenuButton;
            _escMenuUI.OnClickQuitButton += OnClickEscMenuQuitButton;
        }
        #endregion
        #region 事件回调
        private void OnClickMenuButton()
        {
            _escMenuUI.gameObject.SetActive(true);
        }
        private void OnClickEscMenuReturnToGameButton()
        {
            _escMenuUI.gameObject.SetActive(false);
        }
        private void OnClickEscMenuReturnToMenuButton()
        {
            scene.game.LoadMenuScene();
        }
        private void OnClickEscMenuQuitButton()
        {
            scene.game.Quit();
        }
        #endregion
        #endregion
        [SerializeField]
        GameUIPanel _ui;
        [SerializeField]
        EscMenuPanel _escMenuUI;
    }
}