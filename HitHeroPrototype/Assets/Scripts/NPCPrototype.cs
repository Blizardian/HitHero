using UnityEngine;
using System.Collections;

public class NPCPrototype : MonoBehaviour
{
    public Animator animator;

    private Transform defaultCamTransform;
    private Vector3 resetPos;
    private Quaternion resetRot;
    private GameObject cam;
    private GameObject fighter;

    void Start()
    {
        cam = GameObject.FindWithTag("MainCamera");
        defaultCamTransform = cam.transform;
        resetPos = defaultCamTransform.position;
        resetRot = defaultCamTransform.rotation;
        fighter = GameObject.FindWithTag("Opponent");
        fighter.transform.position = new Vector3(0, 0, 2);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            fighter.transform.position = new Vector3(0, 0, 2);
            animator.Play("Idle");
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Walking Forward");
            animator.SetBool("Walk Forward", true);
        }
        else
        {
            animator.SetBool("Walk Forward", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Walking Backward");
            animator.SetBool("Walk Backward", true);
        }
        else
        {
            animator.SetBool("Walk Backward", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Punch!");
            animator.SetTrigger("PunchTrigger");
        }
    }
}