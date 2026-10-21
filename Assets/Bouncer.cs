using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField] private float bounceForce = 3f;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Столкновение! Объект: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Это игрок!");

            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);
                rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
                Debug.Log("Прыжок выполнен!");
            }
            else
            {
                Debug.LogError("У игрока нет Rigidbody!");
            }
        }
    }
}