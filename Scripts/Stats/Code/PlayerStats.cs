using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float health = 10;

    public float accuracy = 10;

    public float dodge = 10;

    public void TakeDamage(float damage)
    {
        if (health > 0)
        {
            // Hit Roll
            float toHit = accuracy + Random.Range(1, 21);
            float toDodge = dodge + Random.Range(1, 21);

            if (toHit >= toDodge)
            {
                Debug.Log("Hit for " + damage + "!");
                Debug.Log("Player lost " + damage + " health!");
                health -= damage;

                if (health <= 0)
                {
                    Debug.Log("Health reached " + health + "! You lose!");
                }
            }
            else
            {
                Debug.Log("Miss!");
            }       
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(Random.Range(1, 4));
        }
    }
}
