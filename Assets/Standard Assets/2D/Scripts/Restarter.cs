using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        [SerializeField]
        private Transform StartZone;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                other.transform.position = StartZone.position;
            }
        }

        public Vector2 getStartZone()
        {
            return StartZone.position;
        }
    }
}
