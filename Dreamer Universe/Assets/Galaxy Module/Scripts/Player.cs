using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GalaxyModule
{
    public class Player : MonoBehaviour
    {
        public TextMeshProUGUI WarpSpeedText;
        public TextMeshProUGUI FuelText;
        public int Fuel = 10000;
        public bool IsGod = false;
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
            WarpSpeedText.text = "WarpSpeed: " + WarpSpeed;
            FuelText.text = "Fuel: " + Fuel;
        }

        public void FixedUpdate()
        {
            transform.Rotate(Vector3.up * mouseHorizontal);
            cam.Rotate(Vector3.right * -mouseVertical);
            if (IsGod == true)
            {
                Vector3 PlayerLocation = this.transform.position;
                WarpSpeed = Mathf.Clamp(WarpSpeed, minFlySpeed, maxFlySpeed);
                velocity = ((transform.forward * vertical) + (transform.right * horizontal) + (transform.up * up)) *
                           Time.fixedDeltaTime * WarpSpeed * SpeedOfLight;
                transform.Translate(velocity, Space.World);
                Vector3 PlayerNewLocation = this.transform.position;
                if (PlayerLocation != PlayerNewLocation)
                {
                    float fueltake = Vector3.Distance(PlayerLocation, PlayerNewLocation);
                    Fuel -= (int)fueltake;
                    FuelText.text = "Fuel: " + Fuel;
                }

            }
        }

        // Update is called once per frame
        void Update()
        {
            if (IsGod == true)
            {
                horizontal = Input.GetAxis("Horizontal");
                vertical = Input.GetAxis("Vertical");
                up = Input.GetAxis("Up");
            }

            mouseHorizontal = Input.GetAxis("Mouse X");
            mouseVertical = Input.GetAxis("Mouse Y");
            mouseWheel = Input.GetAxis("Mouse ScrollWheel");
            if (mouseWheel == 0.1f)
            {
                //Debug.Log(mouseWheel);
                WarpSpeed += mouseScrollSpeed;
                WarpSpeedText.text = "WarpSpeed: " + WarpSpeed;
            }

            if (mouseWheel == -0.1f)
            {
                //Debug.Log(mouseWheel);
                WarpSpeed -= mouseScrollSpeed;
                WarpSpeedText.text = "WarpSpeed: " + WarpSpeed;
            }
        }
    }
}
