using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebote : MonoBehaviour
{

    public bool subida = false;
    public bool bajada = false;
    public float limite = 10;
    

    public int time = 3;
// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // rebote();
           //transform.position += new Vector3(0,-2 * Time.deltaTime,0); 
           //Debug.Log();
           //transform.position += new Vector3(0,-2,0); 
           bajada = true;
        }
        if (bajada==true)
        {
            transform.position += new Vector3((1 * Time.deltaTime), 0, 0);
            transform.position += new Vector3(0, (-3 * Time.deltaTime),0);
            if (transform.position.y <=0)
            {
                bajada = false;
                subida = true;
                limite = limite - 1;
            }
        } 
        if (subida==true)
        {
            transform.position += new Vector3((1 * Time.deltaTime), 0, 0);
            transform.position += new Vector3(0, (3 *Time.deltaTime),0);
        }

        if (transform.position.y>=limite)
        {
            bajada = true;
            subida = false;
            
        }

        if (limite==0)
        {
            bajada = false;
            subida = false;
        }
     

    }

    
       
        
        
    
    
}
