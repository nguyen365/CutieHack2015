using UnityEngine;
using System.Collections;

public class DestroyEnemies : MonoBehaviour
{
	void OnCollisionEnter (Collision collision)
	{
		if(collision.gameObject.name == "Enemy")
		{
			Destroy(collision.gameObject);
		}
	}
}