using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace FairyVerse
{
    public class GameManager : MonoBehaviour
    {
        #region 公有方法
        /// <summary>
        /// 开始游戏
        /// </summary>
        public void StartGame()
        {
            SceneManager.LoadSceneAsync(_gameScenePath, LoadSceneMode.Additive);
        }
        /// <summary>
        /// 退出游戏
        /// </summary>
        public void Quit()
        {
#if UNITY_EDITOR
            if (UnityEditor.EditorApplication.isPlaying)
                UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }
        #endregion
        #region 属性字段
        [SerializeField]
        string _gameScenePath;
        #endregion
    }
    public class StartMenuCtrl : MonoBehaviour
    {
        #region 私有方法
        #region 生命周期
        protected void Awake()
        {
            _ui.onClickStartButton += onClickStartButton;
            _ui.onClickQuitButton += onClickQuitButton;
        }
        #endregion
        #region 事件回调
        private void onClickStartButton()
        {

        }
        private void onClickQuitButton()
        {

        }
        #endregion
        #endregion
        #region 属性字段
        [SerializeField]
        GameManager _game;
        [SerializeField]
        StartMenuPanel _ui;
        #endregion
    }
    public class StartMenuPanel : MonoBehaviour
    {
        #region 私有方法
        #region 生命周期
        protected void Awake()
        {
            _startButton.onClick.AddListener(onClickStartButtonCallback);
            _quitButton.onClick.AddListener(onClickQuitButtonCallback);
        }
        #endregion
        #region 事件回调
        private void onClickStartButtonCallback()
        {
            onClickStartButton?.Invoke();
        }
        private void onClickQuitButtonCallback()
        {
            onClickQuitButton?.Invoke();
        }
        #endregion
        #endregion
        #region 事件
        public event Action onClickStartButton;
        public event Action onClickQuitButton;
        #endregion
        #region 属性字段
        [SerializeField]
        Button _startButton;
        [SerializeField]
        Button _quitButton;
        #endregion
    }
}