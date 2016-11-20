using UnityEngine;
using System.Collections;

public class Flippers : MonoBehaviour {

    public GameObject Flipper_Left;
    public GameObject Flipper_Right;


    private Quaternion initialRotationRight = new Quaternion();
    // Use this for initialization
    void Start () {
        initialRotationRight = Flipper_Right.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Flipper_Right.transform.Rotate(0, 4f, 0);
        }
        else
        {
            Flipper_Right.transform.rotation = initialRotationRight;
        }
	}
}
