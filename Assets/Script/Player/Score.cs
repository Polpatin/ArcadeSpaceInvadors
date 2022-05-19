using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ScoreCount
{
    public class Score : MonoBehaviour
    {
        public static int score;
        public Text ScoreText;
        // Start is called before the first frame update
        void Start()
        {
            ScoreText.text = Convert.ToString("Score: "+score);
        }

        // Update is called once per frame
        void Update()
        {
            ScoreText.text = Convert.ToString("Score: " + score);

        }
    }
}