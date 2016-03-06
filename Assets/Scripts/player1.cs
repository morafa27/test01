using UnityEngine;
using System.Collections;

public class player1 : MonoBehaviour {

	public Vector2 jumForce = new Vector2(0,300);
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")) {
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumForce);
		}
		//die by being off screen
		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) {
			Die();		
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		Die();
	}
	void Die(){
		Application.LoadLevel (Application.loadedLevel);
	}
}
