using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotButton : MonoBehaviour
{
    RectTransform button;

    // Use this for initialization
    void Start () {
        button = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonRotation(int amount)
    {
        //float buttonAngle = amount ;
        button.rotation = Quaternion.Euler (0, 0, -amount+90);
    }
}
