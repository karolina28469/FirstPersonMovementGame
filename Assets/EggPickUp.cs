using UnityEngine;
using UnityEngine.UI;

public class EggPickUp : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    void OnTriggerEnter(Collider other)
    {
        theScore += 50;
        scoreText.GetComponent<Text>().text = "SCORE " + theScore;
        Destroy(gameObject);

    }
}
