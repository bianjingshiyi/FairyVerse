using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace FairyVerse
{
    public class StartMenuPanel : MonoBehaviour
    {
        #region 私有方法
        #region 生命周期
        protected void Awake()
        {
            _startButton.onClick.AddListener(OnClickStartButtonCallback);
            _quitButton.onClick.AddListener(OnClickQuitButtonCallback);
        }
        #endregion
        #region 事件回调
        private void OnClickStartButtonCallback()
        {
            OnClickStartButton?.Invoke();
        }
        private void OnClickQuitButtonCallback()
        {
            OnClickQuitButton?.Invoke();
        }
        #endregion
        #endregion
        #region 事件
        public event Action OnClickStartButton;
        public event Action OnClickQuitButton;
        #endregion
        #region 属性字段
        [SerializeField]
        Button _startButton;
        [SerializeField]
        Button _quitButton;
        #endregion
    }
}