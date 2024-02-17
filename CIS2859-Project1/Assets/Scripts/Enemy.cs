using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  [SerializeField]
  private int health = 1;
  [SerializeField]
  private GameObject healthOrb;


  public void SetHealth(int health){
    this.health = health;
  }

  public void Hurt(int damage){
    health -= damage;
  }

public int GetHealth(){
  return health;
}
public void ReactToHit()
    {   
        if(health <=0){
        StartCoroutine(Die());
        }
    }

    private IEnumerator Die()

    {
        //topple over
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1.5f);

        //die
        Destroy(this.gameObject);
        healthOrb = Instantiate(HealingOrb) as GameObject;

    }


}
