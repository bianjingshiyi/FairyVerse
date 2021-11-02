using System;
using UnityEngine;
using UnityEngine.UI;
namespace FairyVerse
{
    public class EscMenuPanel : MonoBehaviour
    {
        #region 私有方法
        #region 生命周期
        protected void Awake()
        {
            _returnToGameButton.onClick.AddListener(OnClickReturnToGameButtonCallback);
            _returnToMenuButton.onClick.AddListener(OnClickReturnToMenuButtonCallback);
            _quitButton.onClick.AddListener(OnClickQuitButtonCallback);
        }
        #endregion
        #region 事件回调
        private void OnClickReturnToGameButtonCallback()
        {
            OnClickReturnToGameButton?.Invoke();
        }
        private void OnClickReturnToMenuButtonCallback()
        {
            OnClickReturnToMenuButton?.Invoke();
        }
        private void OnClickQuitButtonCallback()
        {
            OnClickQuitButton?.Invoke();
        }
        #endregion
        #endregion
        #region 事件
        public event Action OnClickReturnToGameButton;
        public event Action OnClickReturnToMenuButton;
        public event Action OnClickQuitButton;
        #endregion
        #region 属性字段
        [SerializeField]
        Button _returnToGameButton;
        [SerializeField]
        Button _returnToMenuButton;
        [SerializeField]
        Button _quitButton;
        #endregion
    }
}