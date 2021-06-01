/*******************************************************************************
* 版本声明：v1.0.0
* 类 名 称：DragEventController
* 创建日期：2020-04-13 15:40:05
* 作者名称：末零
* 功能描述：拖拽事件控制
* 修改记录：
* 
******************************************************************************/

using UnityEngine;
using UnityEngine.Events;

using LastZero.BaseEvent;

namespace LastZero.EventSystem
{
    /// <summary>
    /// 拖拽事件控制
    /// </summary>
    public static partial class EventController
    {
        /// <summary>
        /// 添加开始拖拽事件
        /// </summary>
        /// <param name="target">目标</param>
        /// <param name="act">事件</param>
        public static void AddBeginDragEvent(this GameObject target, UnityAction act)
        {
            if (target.GetComponent<DragEvent>() == null)
                target.AddComponent<DragEvent>();

            target.GetComponent<DragEvent>().beginDragEvent.AddListener(act);
        }

        /// <summary>
        /// 添加拖拽功能
        /// </summary>
        /// <param name="target">目标</param>
        /// <param name="act">事件</param>
        public static void AddDragEvent(this GameObject target, UnityAction act)
        {
            if (target.GetComponent<DragEvent>() == null)
                target.AddComponent<DragEvent>();

            target.GetComponent<DragEvent>().dragEvent.AddListener(act);
        }

        /// <summary>
        /// 添加拖拽结束功能
        /// </summary>
        /// <param name="target">目标</param>
        /// <param name="act">事件</param>
        public static void AddEndDragEvent(this GameObject target, UnityAction act)
        {
            if (target.GetComponent<DragEvent>() == null)
                target.AddComponent<DragEvent>();

            target.GetComponent<DragEvent>().endDragEvent.AddListener(act);
        }

        /// <summary>
        /// 移除拖拽事件
        /// </summary>
        /// <param name="target">目标</param>
        public static void RemoveDragEvent(this GameObject target)
        {
            if (target.GetComponent<DragEvent>())
                Object.Destroy(target.GetComponent<DragEvent>());
        }

        /// <summary>
        /// 清空拖拽事件
        /// </summary>
        /// <param name="target">目标</param>
        public static void ClearDragEvent(this GameObject target)
        {
            if (target.GetComponent<DragEvent>())
                target.GetComponent<DragEvent>().ClearEvents();
        }
    }
}