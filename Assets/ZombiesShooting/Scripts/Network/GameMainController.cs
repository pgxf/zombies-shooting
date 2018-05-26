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
		Vector3 pos = GameSettings.In.positions[PhotonNetwork.player.ID - 1];
		Debug.Log(pos);
		currentPlayer = PhotonNetwork.Instantiate("Player", pos, Quaternion.identity, 0);
//		currentPlayer = PhotonNetwork.Instantiate("Player", new Vector3(0, 0, -1), Quaternion.identity, 0);
		Debug.Log("Load done");
	}
}
