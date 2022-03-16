using UnityEngine;

public class ZaminNeyzeh : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.name == "Toop")
			GameObject.Find("Game").GetComponent<Game>().Bakht();
	}
}
