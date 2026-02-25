using UnityEditor.Rendering;
using UnityEngine;

public class PunchChecker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Opponent"))
        {
            Debug.Log("Oponent hit!");
            Debug.Log("Player hit!");
            HPChcker.Instance.opponentHP -= 10;
        }
    }
}
