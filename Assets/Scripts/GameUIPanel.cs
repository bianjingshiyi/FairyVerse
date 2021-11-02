using System;
using UnityEngine;
using UnityEngine.UI;
namespace FairyVerse
{
    public class GameUIPanel : MonoBehaviour
    {
        #region 私有方法
        #region 生命周期
        protected void Awake()
        {
            _menuButton.onClick.AddListener(OnClickMenuButtonCallback);
        }
        #endregion
        #region 事件回调
        private void OnClickMenuButtonCallback()
        {
            OnClickMenuButton?.Invoke();
        }
        #endregion
        #endregion
        #region 事件
        public event Action OnClickMenuButton;
        #endregion
        #region 属性字段
        [SerializeField]
        Button _menuButton;
        #endregion
    }
}