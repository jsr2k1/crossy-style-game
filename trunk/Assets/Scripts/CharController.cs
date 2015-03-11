using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour
{
	Animator anim;
	//Rigidbody rb;
	public float z_jump;
	public float y_jump;
		
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	void Awake()
	{
		anim = GetComponent<Animator>();
		//rb = GetComponent<Rigidbody>();
	}
	
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	void Update()
	{
		if(Input.GetButtonDown("Fire1")){
			anim.SetTrigger("Crouch");
		}
		if(Input.GetButtonUp("Fire1")){
			anim.SetTrigger("Jump");
		}
	}
	
	////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
	void FixedUpdate()
	{
		if(Input.GetButtonUp("Fire1")){
			//rb.AddForce(jumpdir * thrust, ForceMode.Impulse);
			//rb.velocity = new Vector3(0,y_jump,z_jump);
			transform.Translate(Vector3.forward * 2.0f);
		}
	}
}
