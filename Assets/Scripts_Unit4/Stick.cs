using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Golf_Unit4
{
    public class Stick : MonoBehaviour
    {
        public UnityEvent<Collider> onCollision;
        private void OnCollisionEnter(Collision collision)
        {
            onCollision.Invoke(collision.collider);
        }
    }
}
