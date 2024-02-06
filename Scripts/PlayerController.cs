using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float xRange = 10.0f;
    [SerializeField] private GameObject projectile;
    [SerializeField] private GameObject pizza;

    private short projectile_type = 0;
    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (projectile_type == 0)
            {
                Instantiate(projectile, transform.position, projectile.transform.rotation);
                projectile_type = 1;
            }
            else
            {
                Instantiate(pizza, transform.position, projectile.transform.rotation);
                projectile_type = 0;
            }
        }
    }
}
