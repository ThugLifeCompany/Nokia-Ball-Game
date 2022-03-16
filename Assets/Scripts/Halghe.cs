using UnityEngine;

public class Halghe : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Toop")
		{
			GameObject.Find("Game").GetComponent<Game>().emtiaz++;
			Destroy(gameObject);
		}
	}
}
