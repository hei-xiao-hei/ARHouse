using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//

public class UIStarTest : MonoBehaviour {
    Ray ray;
    RaycastHit hit;
    public Transform point;
    //发射射线的位置
    public RectTransform UIStar;
    //准星
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ray = new Ray(point.position, point.forward);
        Debug.DrawRay(ray.origin, ray.direction, Color.red);
        if (Physics.Raycast(ray,out hit,100,1))
        {
            print(hit.point);
            Vector3 point_Temp = Camera.main.
                WorldToScreenPoint(hit.point);
            //将射线检测到的世界中一点转换到屏幕上一点
            UIStar.gameObject.SetActive(true);
            //激活准星
            UIStar.position = point_Temp;
            //给准星指定位置
        }
        else
        {
            UIStar.gameObject.SetActive(false);
        }
	}
}
