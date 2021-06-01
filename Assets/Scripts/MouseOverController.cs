/*******************************************************************************
* 版本声明：v1.0.0
* 类 名 称：MouseOverController
* 创建日期：2020-04-16 13:56:59
* 作者名称：末零
* 功能描述：获取鼠标停留处的物体
* 修改记录：
* 
******************************************************************************/

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace LastZero.Utility
{
	/// <summary>
    /// 类功能描述
    /// </summary>
	public static class MouseOverController
	{
        /// <summary>
        /// 获取鼠标停留处UI
        /// </summary>
        /// <param name="canvas"></param>
        /// <returns></returns>
        public static GameObject GetOverUI(this GameObject canvas)
        {
            PointerEventData pointerEventData = new PointerEventData(UnityEngine.EventSystems.EventSystem.current);
            pointerEventData.position = Input.mousePosition;
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pointerEventData, results);
            if (results.Count != 0)
            {
                return results[0].gameObject;
            }

            return null;
        }

        /// <summary>
        /// 获取鼠标停留处UI
        /// </summary>
        /// <param name="canvas"></param>
        /// <returns></returns>
        public static GameObject GetOverUI(this Transform canvas)
        {
            PointerEventData pointerEventData = new PointerEventData(UnityEngine.EventSystems.EventSystem.current);
            pointerEventData.position = Input.mousePosition;
            GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pointerEventData, results);
            if (results.Count != 0)
            {
                return results[0].gameObject;
            }

            return null;
        }

        /// <summary>
        /// 获取鼠标停留处物体
        /// </summary>
        /// <param name="canvas"></param>
        /// <returns></returns>
        public static GameObject GetOverGameObject(this GameObject camera)
        {
            if (camera.GetComponent<PhysicsRaycaster>() == null)
                camera.AddComponent<PhysicsRaycaster>();

            PointerEventData pointerEventData = new PointerEventData(UnityEngine.EventSystems.EventSystem.current);
            pointerEventData.position = Input.mousePosition;
            PhysicsRaycaster gr = camera.GetComponent<PhysicsRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pointerEventData, results);
            if (results.Count != 0)
            {
                return results[0].gameObject;
            }

            return null;
        }

        /// <summary>
        /// 获取鼠标停留处物体
        /// </summary>
        /// <param name="canvas"></param>
        /// <returns></returns>
        public static GameObject GetOverGameObject(this Transform camera)
        {
            if (camera.GetComponent<PhysicsRaycaster>() == null)
                camera.gameObject.AddComponent<PhysicsRaycaster>();

            PointerEventData pointerEventData = new PointerEventData(UnityEngine.EventSystems.EventSystem.current);
            pointerEventData.position = Input.mousePosition;
            PhysicsRaycaster gr = camera.GetComponent<PhysicsRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pointerEventData, results);
            if (results.Count != 0)
            {
                return results[0].gameObject;
            }

            return null;
        }

        /// <summary>
        /// 获取鼠标停留处物体
        /// </summary>
        /// <param name="canvas"></param>
        /// <returns></returns>
        public static GameObject GetOverGameObject(this Camera camera)
        {
            if (camera.GetComponent<PhysicsRaycaster>() == null)
                camera.gameObject.AddComponent<PhysicsRaycaster>();

            PointerEventData pointerEventData = new PointerEventData(UnityEngine.EventSystems.EventSystem.current);
            pointerEventData.position = Input.mousePosition;
            PhysicsRaycaster gr = camera.GetComponent<PhysicsRaycaster>();
            List<RaycastResult> results = new List<RaycastResult>();
            gr.Raycast(pointerEventData, results);
            if (results.Count != 0)
            {
                return results[0].gameObject;
            }

            return null;
        }
    }
}