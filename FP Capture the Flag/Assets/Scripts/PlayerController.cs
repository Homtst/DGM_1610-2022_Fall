using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement")]
    public float moveSpeed;
    public float jumpForce;
    public int curHp;
    public int maxHp;

    [Header("Camera")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    private float rotX;

    private Camera camera;
    private Rigidbody rb;
    
    void Awake()
    {
        curHp = maxHp;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //Get Components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    //Applies Damage to the Player
    public void TakeDamage(int damage)
    {
        curHp -= damage;
        if(curHp <= 0)
            Die();
    }

    void Die()
    {
        Debug.Log("Player has died! GameOver!");
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraLook();

        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y;
        rb.velocity = dir; // Drives movement relative to the cameras look direction
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X")* lookSensitivity; //Look up and down
        rotX += Input.GetAxis("Mouse Y")* lookSensitivity; //Look Left and Right
        //Restrict rotation on the X-Axis
        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);

        //Drives Camera Rotation
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void Jump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        if(Physics.Raycast(ray, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void GiveHealth(int amountToGive)
    {
        Debug.Log("Player has been healed!");
    }

     public void GiveAmmo(int amountToGive)
    {
        Debug.Log("Player has collected ammo!");
    }
}
