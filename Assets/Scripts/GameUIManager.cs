using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUIManager : MonoBehaviour
{
    // textmeshpro will set in the scene
    // ...UI will in ui
    [SerializeField] TextMeshProUGUI scoreText;

    private void Update()
    {
        scoreText.text = "Score: " + GameManager.Instance.Score;
    }
}
