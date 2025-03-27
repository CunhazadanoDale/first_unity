using UnityEngine;

public class TriggerProjectFile : MonoBehaviour
{
    [SerializeField] GameObject projectfile;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            projectfile.SetActive(true);
            Destroy(gameObject);
        }
    }
}
