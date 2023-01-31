using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript2 : MonoBehaviour
{

    public static TextMeshProUGUI scoreCounterText;
    public static int scoreValue;

    private void Awake()
    {
        scoreCounterText = GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreCounterText.text = scoreValue.ToString();
    }
}
