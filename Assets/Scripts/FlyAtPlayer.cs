using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 1.0f;
    Vector3 playerPosition;

    private void Awake() {
     gameObject.SetActive(false);   
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer() {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime*speed);
    }

    void DestroyWhenReached() {
        if (transform.position == playerPosition) {
            Destroy(gameObject);
        }
    }
}
