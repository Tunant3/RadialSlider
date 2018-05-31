using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSlideRotation : MonoBehaviour
{


    public void CubeRotation(int amount)
    {
        transform.localRotation = Quaternion.Euler (0, amount , 0);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
