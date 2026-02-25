using UnityEngine;
using System.Collections;

public class FighterAnimationDemoFREE : MonoBehaviour {
	
	public Animator animator;

	private Transform defaultCamTransform;
	private Vector3 resetPos;
	private Quaternion resetRot;
	private GameObject cam;
	private GameObject fighter;

	public Collider attackCollider;

    void Start()
    {
        cam = GameObject.FindWithTag("MainCamera");
        defaultCamTransform = cam.transform;
        resetPos = defaultCamTransform.position;
        resetRot = defaultCamTransform.rotation;
        fighter = GameObject.FindWithTag("Player");
        fighter.transform.position = new Vector3(0, 0, -2);
    }

    void Update () 
	{

         if (Input.GetKeyDown(KeyCode.R))
        {
            defaultCamTransform.position = resetPos;
            defaultCamTransform.rotation = resetRot;
            fighter.transform.position = new Vector3(0, 0, -2);
            animator.Play("Idle");
        }


        if (Input.GetKey(KeyCode.D))
		{
			Debug.Log("Walking Forward");
			animator.SetBool("Walk Forward", true);
		}
		else
		{
			animator.SetBool("Walk Forward", false);
		}

		if (Input.GetKey(KeyCode.A)) 
		{
            Debug.Log("Walking Backward");
            animator.SetBool("Walk Backward", true);
		}
		else
		{
			animator.SetBool("Walk Backward", false);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("Punch!");
            animator.SetTrigger("PunchTrigger");
		}
	}
}