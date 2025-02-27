using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform _alvo1;
    public Transform _alvo2;

    public float interpolacao = 12f;
    public SpriteRenderer _spriteRenderrer;
    
    public float CamMoveSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_spriteRenderrer.flipX == true)
        {
            //transform.position = new Vector3(_alvo2.position.x, _alvo2.position.y, transform.position.z);
            
            transform.position = Vector3.Lerp(
                transform.position, 
                new Vector3(_alvo2.position.x,_alvo2.position.y,transform.position.z), 
                CamMoveSpeed * Time.deltaTime);
            

        }
        if (_spriteRenderrer.flipX == false)
        {
            //transform.position = new Vector3(_alvo1.position.x, _alvo1.position.y, transform.position.z);
           
            transform.position = Vector3.Lerp(
                transform.position, 
                new Vector3(_alvo1.position.x,_alvo1.position.y,transform.position.z), 
                CamMoveSpeed * Time.deltaTime);
            
        }
        
        
        
    }
}