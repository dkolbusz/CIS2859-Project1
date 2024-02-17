using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectiles : MonoBehaviour
{
    [SerializeField]
    private GameObject fireballPrefab;
    private GameObject fireball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
             fireball = Instantiate(fireballPrefab) as GameObject;
                    //place fireball in front of the enemy and point in the same direction
                    fireball.transform.position = 
                        transform.TransformPoint(Vector3.forward * 1.5f);
                    fireball.transform.rotation = transform.rotation;
        }
    }
}
