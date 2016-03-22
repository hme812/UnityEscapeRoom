using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {
	GameObject secondHand;
	// Use this for initialization
	void Start () {
		secondHand = GameObject.Find ("SecondHand");
	}
	
	// Update is called once per frame
	void Update () {
		secondHand.transform.Rotate (10, 0, 0);
	}
}
