using UnityEngine;

public class carMove : MonoBehaviour
{
    private Transform myTransform;
    private Vector3 myPosition;

    void Start()
    {
        myTransform = transform;
        myPosition = transform.position;
        myTransform.Translate(0, 0, 2);
    }

    void Update()
    {
        myPosition += myTransform.forward * 2.0f * Time.deltaTime;
        myTransform.position = myPosition;
    }
}
