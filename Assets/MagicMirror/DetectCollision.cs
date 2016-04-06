using UnityEngine;
using System.Collections;

public class DetectCollision : MonoBehaviour {
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

 //   void OnCOllisionEnter(Collision col){//Why this doesn't work??
 //       print("Collide");
	//	if (col.gameObject.name == "RedFlower") {
	//		Destroy (col.gameObject);
	//	}
	//}

 //   void OnCollisionEnter2D(Collision2D collision)
 //   {
 //       print("Collided!");
 //       if (collision.gameObject.tag == "RedFlower")
 //       {
 //           Destroy(gameObject);
 //       }
 //   }

    void OnCollisionEnter(Collision collision)
    {
        print("Detected!");
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
            print("Detected");
            print(collision.gameObject.name);
            if (collision.gameObject.name == "FrontWall")
            {
                print("play audio");
                audio.Play();
				//Destroy (this.gameObject);
            }
        }


    }

}
