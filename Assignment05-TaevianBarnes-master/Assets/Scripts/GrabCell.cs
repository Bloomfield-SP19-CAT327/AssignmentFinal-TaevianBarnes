using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabCell : MonoBehaviour {

    //MUST EDIT
    
    public AudioSource audioSource;
    public AudioClip cellGrab;

    public int cellsLeft;

    public Text cellText;

    [Range(0.0f, 1.0f)]
    public float cellVolume;

    void Start()
    {
        cellsLeft = 40;
        SetCountText();
    }
    
   


    void Update()
    {
        if (cellsLeft <= 0)
        {
            cellsLeft = 0;
        }
    }


    private void OnTriggerEnter(Collider objectCollided)
    {
        if (objectCollided.gameObject.tag == "Collectable")
        {
            GameManager.cellCount++;

            cellsLeft = cellsLeft - 1;


            print("I have " + GameManager.cellCount + " Artifacts!");

            Destroy(objectCollided.gameObject);

            SetCountText();
        }


    }

    void SetCountText()
    {
        //cellText.text = "Artifacts Needed: " + cellsLeft.ToString ();
    }
}
