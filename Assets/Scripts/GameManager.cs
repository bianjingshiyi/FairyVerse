using System;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace FairyVerse
{
    public class GameManager : MonoBehaviour
    {
        #region 公有方法
        /// <summary>
        /// 加载开始菜单界面
        /// </summary>
        public void LoadMenuScene()
        {
            if (SceneManager.GetSceneByPath(_gameScenePath).isLoaded)
            {
                UnloadGameScene(() => SceneManager.LoadSceneAsync(_menuScenePath, LoadSceneMode.Additive));
            }
            else
                SceneManager.LoadSceneAsync(_menuScenePath, LoadSceneMode.Additive);
        }
        /// <summary>
        /// 卸载菜单场景
        /// </summary>
        public void UnloadMenuScene(Action onComplete = null)
        {
            AsyncOperation operation = SceneManager.UnloadSceneAsync(_menuScenePath);
            operation.completed += o =>
            {
                onComplete?.Invoke();
            };
        }
        /// <summary>
        /// 加载游戏场景
        /// </summary>
        public void LoadGameScene()
        {
            if (SceneManager.GetSceneByPath(_menuScenePath).isLoaded)
            {
                UnloadMenuScene(() => SceneManager.LoadSceneAsync(_gameScenePath, LoadSceneMode.Additive));
            }
            else
                SceneManager.LoadSceneAsync(_gameScenePath, LoadSceneMode.Additive);
        }
        /// <summary>
        /// 卸载游戏场景
        /// </summary>
        public void UnloadGameScene(Action onComplete = null)
        {
            AsyncOperation operation = SceneManager.UnloadSceneAsync(_gameScenePath);
            operation.completed += o =>
            {
                onComplete?.Invoke();
            };
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
        #region 私有方法
        protected void Awake()
        {
            //加载开始菜单
            LoadMenuScene();
        }
        #endregion
        #region 属性字段
        [SerializeField]
        string _menuScenePath;
        [SerializeField]
        string _gameScenePath;
        #endregion
    }
}