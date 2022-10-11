using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWindow : MonoBehaviour
{
    public GameObject Buiding;
    public GameObject HouseType_1;
    public GameObject HouseType_2;
    public GameObject InDoorItem_Btn;
    public GameObject InWindow_Img;

    private CanvasGroup canvasGroup;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //开始的时候隐藏大楼
        if(Buiding!=null)
        {
            Buiding.SetActive(false);
        }
        canvasGroup = GetComponent<CanvasGroup>();
        
    }

    public void OutDoor_Btn()
    {
        if(Buiding!=null)
        {
            Buiding.SetActive(true);
            HouseType_1.SetActive(false);
            HouseType_2.SetActive(false);

        }
        Debug.Log("室外大楼");
    }


    public void InDoor_Btn()
    {
        if(InDoorItem_Btn!=null)
        {
            //关闭BlockRaycast，UI之间不再通信
            canvasGroup.blocksRaycasts = false;
            //激活户型选择的UI
            InDoorItem_Btn.SetActive(true);

        }
        Debug.Log("室内大楼");
    }

    public void About_Btn()
    {
        if(InWindow_Img!=null)
        {
            canvasGroup.blocksRaycasts = false;
            InWindow_Img.SetActive(true);
        }
        Debug.Log("关于我司");
        
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
