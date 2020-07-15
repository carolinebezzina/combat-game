using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AttackScript : MonoBehaviour {

    public void Attack()
    {
        if (EnemyScript.health > 0)
        {
            if (EnemyScript.health - CharacterScript.strength < 0)
            {
                EnemyScript.health = 0;
            }
            else
            {
                EnemyScript.health = EnemyScript.health - CharacterScript.strength;
            }
        }
    }

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
