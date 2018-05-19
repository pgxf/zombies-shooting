using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectRoom : Photon.MonoBehaviour
{
	public bool connected;
	public string version;
	public string roomName = "ZombiesShooting";

	public GameObject currentPlayer;

	void Start()
	{
		PhotonNetwork.autoJoinLobby = true;
	}

	void Update()
	{
		if (!connected && !PhotonNetwork.connected)
		{
			connected = true;
			PhotonNetwork.ConnectUsingSettings(version);
		}
	}

	void OnJoinedLobby()
	{
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.MaxPlayers = GameSettings.In.maxPlayer;
		PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, null);
	}

	void OnJoinedRoom()
	{
		Debug.Log("On Joined Room");
		PhotonNetwork.player.NickName = "Player" + PhotonNetwork.player.ID;
		currentPlayer = PhotonNetwork.Instantiate("Player", new Vector3(0, 0, -1), Quaternion.identity, 0);
		Debug.Log("Load done");
	}
}
