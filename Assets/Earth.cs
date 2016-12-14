using UnityEngine;
using System.Collections;

public class Earth : MonoBehaviour {

    public AudioSource Screech;
    public AudioSource Fail;
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bat")
        {
            AudioSource screech = Instantiate(Screech);
            screech.clip = Screech.clip;
            screech.Play();
            
            Destroy(gameObject);
        }

        else
        {
            AudioSource fail = Instantiate(Fail);
            fail.clip = Fail.clip;
            fail.Play();

            Destroy(gameObject);
        }


    }
}
