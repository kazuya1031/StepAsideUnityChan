using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControll : MonoBehaviour {
	protected GameObject unitychan;



	// Use this for initialization
	void Start () {
		this.unitychan = GameObject.Find ("unitychan");
		
	}
	
	// Update is called once per frame
	void Update () {
		AutoDestroy ();

	}

	public void AutoDestroy(){
			float difference = unitychan.transform.position.z - this.transform.position.z;

			if (difference > 3) {
				Destroy (this.gameObject);
			}  

      }

}