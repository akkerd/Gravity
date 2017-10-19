using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlatform : MonoBehaviour {

    public float rotationFactor;
    public float initAcc;
    public float deltaAcc;
    public float maxAcc;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if( initAcc <= maxAcc)
            initAcc += deltaAcc;

        this.transform.Rotate(0, 0, rotationFactor*Time.deltaTime*initAcc);
    }
}
