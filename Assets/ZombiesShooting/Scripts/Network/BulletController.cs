using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : Photon.MonoBehaviour
{
	private float moveSpeed = 10f;

	private IEnumerator<WaitForSeconds> Travel()
	{
		yield return new WaitForSeconds(1);

		if (photonView.isMine)
		{
			PhotonNetwork.Destroy(gameObject);
		}
	}

	public void Start()
	{
		StartCoroutine(Travel());
	}

	public void Update()
	{
		transform.position += transform.up * moveSpeed * Time.deltaTime * -1;
	}

	public void OnCollisionEnter2D(Collision2D other)
	{
		if (photonView.isMine)
		{
			PhotonNetwork.Destroy(gameObject);
		}
	}
}
