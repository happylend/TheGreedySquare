using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ShowPeople : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image people0;
    public Image people1;
    // Use this for initialization

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer Enter..");
        people0.gameObject.active = true;
        people1.gameObject.active = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer Exit..");
        people0.gameObject.active = false;
        people1.gameObject.active = false;
    }

}
