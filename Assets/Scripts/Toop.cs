using UnityEngine;

public class Toop : MonoBehaviour
{
	public bool isOnGround;
	public Rigidbody2D rigid;
	public float moveSpeed;
	public float jumpPower;
	public LayerMask layerMask;

	void Update()
	{
		if (Input.GetKey(KeyCode.A))
		{
			rigid.velocity += Vector2.left * moveSpeed;
		}

		if (Input.GetKey(KeyCode.D))
		{
			rigid.velocity += Vector2.right * moveSpeed;
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (isOnGround == true)
			{
				rigid.AddForce(Vector3.up * jumpPower);
			}
		}

		CheckIsGrounded();
	}

	private void CheckIsGrounded()
	{
		Debug.DrawRay(transform.position, -Vector2.up * 0.5f, Color.green);
		if (Physics2D.Raycast(transform.position, -Vector2.up, 0.5f, layerMask))
			isOnGround = true;
		else
			isOnGround = false;
	}
}
