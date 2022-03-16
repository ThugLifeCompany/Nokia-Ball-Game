using UnityEngine;

public class Game : MonoBehaviour
{
	public GameObject bakhtUI;
	public GameObject playanUI;
	public int emtiaz;

	public void Bakht()
	{
		bakhtUI.SetActive(true);
		Time.timeScale = 0;
	}

	public void Payan()
	{
		playanUI.SetActive(true);
		Time.timeScale = 0;
	}
}
