using BJSYGameCore;
using UnityEngine;
namespace FairyVerse
{
    public class GameObjectCtrl<T> : MonoBehaviour where T : SceneCtrl
    {
        #region 私有字段
        #region 生命周期
        protected virtual void Awake()
        {
            if (_scene == null)
                _scene = TransformHelper.findComponentInScene<T>(gameObject.scene);
        }
        #endregion
        #endregion
        #region 属性字段
        public T scene => _scene;
        [SerializeField]
        T _scene;
        #endregion
    }
}