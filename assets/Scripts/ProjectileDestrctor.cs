using UnityEngine;
using System.Collections;

public class ProjectileDestrctor : MonoBehaviour {

	public GameObject explosionPrefab;
	public GameObject explosionPrefabBoss;

	void OnCollisionEnter (Collision newCollision)
	{


		if (newCollision.gameObject.tag == "Projectile"){
		if (explosionPrefab) {
			// Instantiate an explosion effect at the gameObjects position and rotation
				Instantiate (explosionPrefab, newCollision.gameObject.transform.position, newCollision.gameObject.transform.rotation);
		}

			Destroy (newCollision.gameObject);

	}

		if (newCollision.gameObject.tag == "Projectile_Boss")
		{
		
			if (explosionPrefabBoss) 
			{
				// Instantiate an explosion effect at the gameObjects position and rotation
				Instantiate (explosionPrefabBoss, newCollision.gameObject.transform.position, newCollision.gameObject.transform.rotation);
			}
			
			Destroy (newCollision.gameObject);

		}
	}


	}
