using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private int damage = 1;
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime); //move forward
    }

private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if(player != null)
        {
            player.Hurt(damage);
        }
        Destroy(this.gameObject);
    }

}
