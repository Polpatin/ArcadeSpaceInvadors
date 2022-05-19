using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Miror
{
    public class MirorCoordinats : MonoBehaviour
    {
        public static Transform miror;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            miror = transform;
        }
    }
}