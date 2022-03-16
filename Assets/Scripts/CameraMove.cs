using UnityEngine;

public class CameraMove : MonoBehaviour
{
	public Transform toop;

    void Update()
    {
		transform.position = new Vector3(toop.transform.position.x, transform.position.y, -10);
    }
}
