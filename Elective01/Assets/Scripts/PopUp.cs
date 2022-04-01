using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour, IPopUpable
{
    public void Close(GameObject GO)
    {
        GO.SetActive(false);
    }

    void IPopUpable.PopUp(GameObject GO)
    {
        GO.SetActive(true);
    }
}
