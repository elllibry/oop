using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private Vector3 spawnPoint = new Vector3(502, 1, 93);

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("DeathZone сработал! Объект: " + other.gameObject.name);

        if (other.CompareTag("Player"))
        {
            other.transform.position = spawnPoint;
            Debug.Log("Игрок телепортирован!");
        }
    }
}