using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destr : MonoBehaviour
{
    public GameObject element;
    public GameObject menu;

    public void Dest()
    {
        RectTransform rt = menu.GetComponent(typeof(RectTransform)) as RectTransform;
        rt.sizeDelta = new Vector2(rt.sizeDelta.x, rt.sizeDelta.y - 540);
        Destroy(element);
    }
}
