using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntermationWindow : MonoBehaviour
{
    public GameObject Item_Btn;//获取
    public CanvasGroup canvasGroup;
    // Start is called before the first frame update
    void Start()
    {
        if (Item_Btn != null)
        {
            canvasGroup = Item_Btn.GetComponent<CanvasGroup>();
        }
        gameObject.SetActive(false);
    }
    public void Exit_Btn()
    {
        canvasGroup.blocksRaycasts = true;
        gameObject.SetActive(false);
    }
}
