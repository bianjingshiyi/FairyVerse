using BJSYGameCore;
using UnityEngine;
namespace FairyVerse
{
    public abstract class SceneCtrl : MonoBehaviour
    {
    }
    public class SceneCtrl<T> : SceneCtrl where T : Component
    {
        #region 私有方法
        protected void Awake()
        {
            if (_game == null)
                _game = TransformHelper.findComponentInAllScenes<GameManager>();
        }
        #endregion
        #region 属性字段
        public GameManager game => _game;
        [SerializeField]
        GameManager _game;
        #endregion
    }
}