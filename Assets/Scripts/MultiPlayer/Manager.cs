using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace Com.Kawaiisun.SimpleMostile{
    public class Manager : MonoBehaviour
    {
        public string Player_Prefabs;
        public Transform[] Spawn_Point;
        // Start is called before the first frame update
        private void Start()
        {
            Spawn();
        }

        // Update is called once per frame
        public void Spawn()
        {
            PhotonNetwork.Instantiate(Player_Prefabs, Spawn_Point[0].position, Spawn_Point[0].rotation);
        }
    }
}
