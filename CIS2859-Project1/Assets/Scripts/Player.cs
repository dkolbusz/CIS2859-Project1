using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{         
        private int health;

    void Start()
    {
        health = 25;
    }

    public void Hurt(int damage)
    {
        health -= damage;

    }


    public void Heal(int heal){
        health += heal;

    }

    public int GetHealth(){
        return health;
    }
}

