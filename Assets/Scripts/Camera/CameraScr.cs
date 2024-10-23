using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targObj;  // Об'єкт, за яким стежить камера
    public int camHeigh = 0;
    public int camMoveSpeed = 0;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;  // Основна камера
    }

    void FixedUpdate()
    {

    }

    void Update()
    {
        Vector3 camPos = cam.transform.position;
        Vector3 objPos = targObj.position;
        //transform.localPosition = new Vector3(objPos.x, objPos.y, objPos.z + camHeigh);

        if (objPos.x > camPos.x)
        {
            transform.localPosition += new Vector3(3, 0, 0) * Time.smoothDeltaTime;
        }
    }
}