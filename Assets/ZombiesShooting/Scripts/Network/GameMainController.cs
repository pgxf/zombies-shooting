using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMainController : Photon.MonoBehaviour
{
	public GameObject currentPlayer;

	void OnJoinedRoom()
	{
		Debug.Log("On Joined Room");
		PhotonNetwork.player.NickName = "Player" + PhotonNetwork.player.ID;
		currentPlayer = PhotonNetwork.Instantiate("Player", new Vector3(0, 0, -1), Quaternion.identity, 0);
		Debug.Log("Load done");
	}
}
