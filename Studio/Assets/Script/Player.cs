using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3.0f;
    public float moveSpeed = 1;
    // public float rotateSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        float h = Input.GetAxis("Horizontal");//获取轴  
        float v = Input.GetAxis("Vertical");  
        Vector3 targetDir = new Vector3(h, 0, v); 
        transform.Translate(targetDir * Time.deltaTime * speed,Space.World);

        //创建旋转
        // Quaternion newRotation = Quaternion.LookRotation(targetDir, Vector3.up);
        // transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
    }



}
