using UnityEngine;

public class NoghtePayan : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Toop")
			GameObject.Find("Game").GetComponent<Game>().Payan();
	}
}
