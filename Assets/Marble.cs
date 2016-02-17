using UnityEngine;
using System.Collections;

public class Marble : MonoBehaviour {

	public float speed = 500f;
	public float sensH = 10;
	public float sensV = 10;
	Rigidbody2D rigidBody;
	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
	}


	void FixedUpdate()
	{
		float moveHor = Mathf.Clamp (Input.acceleration.x * sensH, -1, 1);
		float moveVer = Mathf.Clamp (Input.acceleration.y * sensV, -1, 1);
		rigidBody.AddForce (new Vector3 (moveHor,moveVer,0 ) * speed * Time.deltaTime);
	}
	// Update is called once per frame
	/*void Update () {
	
	
	if(Input.GetKey(KeyCode.W))
		{
			transform.position += transform.up * 50.0f * Time.deltaTime;	
		}
	if(Input.GetKey(KeyCode.S))
		{
			transform.position -= transform.up * 50.0f * Time.deltaTime;	
		}
	if(Input.GetKey(KeyCode.A))
		{
			transform.position -= transform.right * 50.0f * Time.deltaTime;	
		}
	if(Input.GetKey(KeyCode.D))
		{
			transform.position += transform.right * 50.0f * Time.deltaTime;	
		}

	}*/



	void OnTriggerEnter2D(Collider2D coll)
	{

		if (coll.tag == "Hole") {
			transform.position = new Vector2(-67,30);
		}
		if (coll.name == "Goal") {
			if(Application.loadedLevel == 1)
			{
				Application.LoadLevel(2);
			}else{
				Application.LoadLevel(0);
			}

		}
	}


}