using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 40f;
    [SerializeField] private bool is_animal = false;
    private float topBound = 30f;
    private float lowerBound = -10f;
    void Update()
    { 
        transform.Translate(Vector3.forward *  speed * Time.deltaTime);

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
                Destroy(gameObject);

                if (is_animal)
                {
                    Debug.Log("GAME OVER");
                }
        }
    }
}
