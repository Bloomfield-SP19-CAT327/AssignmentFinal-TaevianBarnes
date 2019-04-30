using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{

    public GameObject buttonCanvas;

    void Start()
    {
        buttonCanvas.SetActive(false);
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Finish")
        {
            if (GameManager.cellCount >= 30)
            {
                buttonCanvas.SetActive(true);
            }
        }
    }
}
