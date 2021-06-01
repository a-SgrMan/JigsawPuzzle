/*******************************************************************************
* 版本声明：v1.0.0
* 类 名 称：DragEvent
* 创建日期：2020-04-13 15:00:04
* 作者名称：末零
* 功能描述：拖拽事件基类
* 修改记录：
* 
******************************************************************************/

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace LastZero.BaseEvent
{
	/// <summary>
    /// 拖拽功能
    /// </summary>
	public class DragEvent : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        /// <summary>
        /// 开始拖拽事件
        /// </summary>
        public UnityEvent beginDragEvent = new UnityEvent();
        /// <summary>
        /// 拖拽事件
        /// </summary>
        public UnityEvent dragEvent = new UnityEvent();
        /// <summary>
        /// 结束拖拽事件
        /// </summary>
        public UnityEvent endDragEvent = new UnityEvent();

        /// <summary>
        /// 开始拖拽事件接口实现
        /// </summary>
        /// <param name="eventData"></param>
        public void OnBeginDrag(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left) beginDragEvent.Invoke();
        }

        /// <summary>
        /// 拖拽事件接口实现
        /// </summary>
        /// <param name="eventData"></param>
        public void OnDrag(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left) dragEvent.Invoke();
        }

        /// <summary>
        /// 结束拖拽事件接口实现
        /// </summary>
        /// <param name="eventData"></param>
        public void OnEndDrag(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left) endDragEvent.Invoke();
        }

        /// <summary>
        /// 清空事件
        /// </summary>
        public void ClearEvents()
        {
            beginDragEvent = null;
            dragEvent = null;
            endDragEvent = null;
        }
    }
}