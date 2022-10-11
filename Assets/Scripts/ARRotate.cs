using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARRotate : MonoBehaviour
{
    Touch oldTouch1;//上次触摸点1
    Touch oldTouch2;//上次触摸点2

    Touch newTouch1;//新的触摸点1
    Touch newTouch2;//新的触摸点2
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //如果当前未触碰屏幕
        if(Input.touchCount<=0)
        {
            return;
        }
        //旋转    如果当前有一个手指点击了手指
        else if (Input.touchCount==1)
        {
            //获取到第一个接触到屏幕的点
            Touch firstTouch = Input.GetTouch(0);
            Vector2 deltaPos = firstTouch.deltaPosition;//定义一个二维的向量用于存储手指点击的位移数据等

            //当X或Y轴的位置变化大于3
            if(Mathf.Abs(deltaPos.x)>=3||Mathf.Abs(deltaPos.y)>=3)
            {
                //以Vector3.down（0，-1，0）乘以deltaPos.x旋转，以自己为轴心
                transform.Rotate(Vector3.back * deltaPos.x, Space.Self);
                //以Vector3.right（1，0，0）乘以deltaPos.y旋转，以自己为轴心
                transform.Rotate(Vector3.left * deltaPos.y, Space.Self);
            }

        }
        //缩放
        else if(Input.touchCount==2)
        {
            //获取两个新的触摸点
            newTouch1 = Input.GetTouch(0);
            newTouch2 = Input.GetTouch(1);

           //当第二个手机开始触摸屏幕，就赋值两个旧的触碰点
            if(newTouch2.phase==TouchPhase.Began)
            {
                oldTouch2 = newTouch2;
                oldTouch1 = newTouch1;
                return;
            }
            //计算老的两个点之间的距离。
            float oldDistance = Vector2.Distance(oldTouch1.position, oldTouch2.position);
            //计算两个新的点之间的距离
            float newDistance = Vector2.Distance(newTouch1.position, newTouch2.position);
            //计算两个距离的差值
            float offset = newDistance - oldDistance;

            //如果offset的绝对值大于或等于3
            if(Mathf.Abs(offset)>=3)
            {
                //缩小因子
                float scaleFactor = offset / 100f;
                //存储当前的Scale值
                Vector3 localScale = transform.localScale;

                Vector3 scale = new Vector3(localScale.x + scaleFactor, localScale.y + scaleFactor, localScale.z + scaleFactor);

                //最小缩放到0.3倍，最大1.5
                if(scale.x>0.5f&&scale.x<10.0f)
                {
                    transform.localScale = scale;//赋新值
                }
                //记住最新的触摸点，下次使用
                oldTouch1 = newTouch1;
                oldTouch2 = newTouch2;
            }

        }
    }
}
