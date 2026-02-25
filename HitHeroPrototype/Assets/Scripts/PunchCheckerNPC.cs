using UnityEditor.Rendering;
using UnityEngine;

public class PunchCheckerNPC : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player hit!");
            HPChcker.Instance.playerHP -= 20;
        }
    }
}
