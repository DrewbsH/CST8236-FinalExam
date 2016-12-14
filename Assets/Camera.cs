using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    private float rotationSpeed = 7.0f;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(transform.parent.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(transform.parent.position, Vector3.up, -rotationSpeed * Time.deltaTime);
        }

    }
}
