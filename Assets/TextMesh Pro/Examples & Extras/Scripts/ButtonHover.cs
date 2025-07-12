using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHover01 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Highlight;
    public GameObject hand;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Highlight.SetActive(true);
        hand.SetActive(true);
        hand.transform.position = transform.position + new Vector3(-100, 0, 0); // Adjust offset
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Highlight.SetActive(false);
        hand.SetActive(false);
    }
}
