using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    // get is public set is private
    public int Score
    {
        get; private set;
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("Multiple GameManagers, Destroying one");
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddScore(int add)
    {
        Score += add;
    }
}
