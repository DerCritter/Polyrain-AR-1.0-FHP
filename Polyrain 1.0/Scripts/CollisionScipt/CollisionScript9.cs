using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript9 : MonoBehaviour {


	public AudioSource collisionSound;
	public GameObject EnemyParticle;

	// Use this for initialization
	void Start () {
		collisionSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void OnCollisionEnter (Collision collision)
	{

		if(collision.gameObject.tag == "target"){
			

	    FindObjectOfType<AudioManager> ().Play ("Note9");

		Instantiate(EnemyParticle,transform.position,Quaternion.identity);

		//ScaleCubes();

		//sound.Play();
		//??transform.position = Vector3.one * 9999f;
		Destroy(gameObject);

	}

	//private void OnCollisionStay(Collision collision){
		

}
}
