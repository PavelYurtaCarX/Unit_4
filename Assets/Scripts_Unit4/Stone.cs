using System.Collections;
using System.Collections.Generic;
using Golf;
using UnityEngine;

namespace Golf_Unit4
{
    public class Stone : MonoBehaviour
    {
        public bool isAffect = false;


        public static System.Action onCollisionStone;
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.TryGetComponent(out Stone other))
            {
                if (!other.isAffect)
                {
                    onCollisionStone?.Invoke();
                    //GameEvents.CollisonStonesInvoke(collision);
                }
            }
        }
    }
}
