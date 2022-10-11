using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDoorWindow : MonoBehaviour
{
    public GameObject Item_Btn;
    public GameObject Buiding;
    public GameObject House1;
    public GameObject House2;
    private CanvasGroup canvasGroup;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        if(Item_Btn!=null)
        {
            canvasGroup = Item_Btn.GetComponent<CanvasGroup>();
        }
        House1.SetActive(false);
        House2.SetActive(false);
    }

    public void HouseType_1()
    {
        Buiding.SetActive(false);
        House1.SetActive(true);
        House2.SetActive(false);
        canvasGroup.blocksRaycasts = true;
        gameObject.SetActive(false);
    }
    public void HouseType_2()
    {
        Buiding.SetActive(false);
        House1.SetActive(false);
        House2.SetActive(true);
        canvasGroup.blocksRaycasts = true;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
