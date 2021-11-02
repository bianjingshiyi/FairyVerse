using UnityEngine;
namespace FairyVerse
{
    public class StartMenuCtrl : GameObjectCtrl<MenuSceneCtrl>
    {
        #region 私有方法
        #region 生命周期
        protected override void Awake()
        {
            base.Awake();
            if (_ui == null)
                _ui = GetComponent<StartMenuPanel>();
            _ui.OnClickStartButton += OnClickStartButton;
            _ui.OnClickQuitButton += OnClickQuitButton;
        }
        #endregion
        #region 事件回调
        private void OnClickStartButton()
        {
            scene.game.LoadGameScene();
        }
        private void OnClickQuitButton()
        {
            scene.game.Quit();
        }
        #endregion
        #endregion
        #region 属性字段

        [SerializeField]
        StartMenuPanel _ui;
        #endregion
    }
}