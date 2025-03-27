using System.Xml.Schema;
using Unity.VisualScripting;
using UnityEngine;

public class Moveout : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotationSpeed = 100f;

    void Start()
    {
        PrintInstructions();
    }

    
    void Update()
    {
        MoverPlayer();
    }

    void PrintInstructions() {
        Debug.Log("Welcome Manuel!");

    }

    void MoverPlayer() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0.00f;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }

}
