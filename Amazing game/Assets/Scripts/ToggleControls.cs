using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleControls : MonoBehaviour
{
    public GameObject controls;

    public void toggle() {
        bool isActive = controls.activeInHierarchy;
        controls.SetActive(!isActive);

    }

}
