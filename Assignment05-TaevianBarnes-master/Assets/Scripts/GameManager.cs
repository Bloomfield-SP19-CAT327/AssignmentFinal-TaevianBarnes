using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int cellCount;

    

    // Start is called before the first frame update
    void Start()
    {
        
        cellCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Finish")
        {
            if (cellCount >= 30)
            {
                buttonCanvas.setActive(true);
            }
        }
    }*/
}
