using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectileBehavior : MonoBehaviour
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
        Enemy enemy = other.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.ReactToHit();
            enemy.Hurt(damage);
        }
        Destroy(this.gameObject);
    }

}
