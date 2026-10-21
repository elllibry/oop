using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 2f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Получаем текущую скорость (чтобы не сбрасывать вертикальную)
        Vector3 currentVelocity = rb.linearVelocity;

        // Применяем движение по X и Z
        rb.linearVelocity = new Vector3(x * speed, currentVelocity.y, z * speed);
    }

    void Update()
    {
        // Прыжок только при нажатии пробела
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}