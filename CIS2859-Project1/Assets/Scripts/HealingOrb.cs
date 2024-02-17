using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingOrb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if(player != null)
        {
            player.Heal(2);
        }
        Destroy(this.gameObject);
    }
}
