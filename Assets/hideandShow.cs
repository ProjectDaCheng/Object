using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideandShow : MonoBehaviour
{
    public GameObject obj;
    public void active_cube() {
        if (!obj.activeInHierarchy)
        {
            obj.SetActive(true);
        }
        else
        {
            obj.SetActive(false);
        }
    }
}
