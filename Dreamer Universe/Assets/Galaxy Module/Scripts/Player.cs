using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    const float SpeedOfLight = 9.461f;
    public float WarpSpeed = 3f;
    public float maxFlySpeed = 300f;
    public float minFlySpeed = 1f;
    private Transform cam;
    private Vector3 velocity;
    private float horizontal;
    private float vertical;
    private float up;
    private float mouseHorizontal;
    private float mouseVertical;
    private float mouseWheel;
    public float mouseScrollSpeed;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera").transform;
    }
    public void FixedUpdate()
    {
        transform.Rotate(Vector3.up * mouseHorizontal);
        cam.Rotate(Vector3.right * -mouseVertical);
        WarpSpeed = Mathf.Clamp(WarpSpeed, minFlySpeed, maxFlySpeed);
        transform.Translate(velocity, Space.World);
        velocity = ((transform.forward * vertical) + (transform.right * horizontal) + (transform.up * up)) * Time.fixedDeltaTime * WarpSpeed * SpeedOfLight;
    }
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        up = Input.GetAxis("Up");
        mouseHorizontal = Input.GetAxis("Mouse X");
        mouseVertical = Input.GetAxis("Mouse Y");
        mouseWheel = Input.GetAxis("Mouse ScrollWheel");
        if (mouseWheel == 0.1f)
        {
            //Debug.Log(mouseWheel);
            WarpSpeed += mouseScrollSpeed;
        }
        if (mouseWheel == -0.1f)
        {
            //Debug.Log(mouseWheel);
            WarpSpeed -= mouseScrollSpeed;
        }
    }
}
