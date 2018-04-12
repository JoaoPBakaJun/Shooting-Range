using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target50m : MonoBehaviour {

	/*public float health = 50f;

    public void TakeDamage (float damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }*/
	public static float score = 0f;

	void OnCollisionEnter()
	{
		score += 50;
		Debug.Log ("Hit + 50 pts");
	}

	/*public void GainScore(float gScore)
	{
		score += gScore;
	}*/


}
