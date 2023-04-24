using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore { get; set; }
    
    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + theScore;
    }
}
