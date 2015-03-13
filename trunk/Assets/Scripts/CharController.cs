using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour
{
	Animator anim;
	Rigidbody rb;
	public float z_jump;
	public float y_jump;
	Vector3 jumpdir = new Vector3(0,1,1);
	public float thrust=1;
	float distToGround;
	int jumpCounter=0;
		
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	void Awake()
	{
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();
		distToGround = collider.bounds.extents.y;
	}
	
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	void Update()
	{
		
	}
	
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	void FixedUpdate()
	{
		if(Input.GetButtonUp("Fire1")){
			jumpCounter++;
		}
		if(jumpCounter>0 && IsGrounded()){
			rb.velocity = new Vector3(0,y_jump*thrust,z_jump*thrust);
			if(jumpCounter>0){
				jumpCounter--;
			}
		}
	/*
		if(Input.GetButtonUp("Fire1")){
			if(IsGrounded()){
				rb.velocity = new Vector3(0,y_jump*thrust,z_jump*thrust);
				transform.localScale=new Vector3(1,1,1);
			}
		}*/
	}
	
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	bool IsGrounded()
	{
		//return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
		return transform.position.y < 0.05f;
	}
}




