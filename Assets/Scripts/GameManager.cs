using TMPro;
using UnityEngine;
//using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject box;
    public float spawnRate;
    public Transform spawnPoint;
    public float maxX;
    bool gameStarted=false;
    public TextMeshProUGUI scoreText;
    int score;
    public GameObject tapText;
    public GameObject BannerImage;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartSpawning();
            gameStarted = true;
            tapText.SetActive(false);
            BannerImage.SetActive(false);
        }
    }
    void StartSpawning()
    {
        InvokeRepeating("spawnBox",0.5f,spawnRate);
    }

    private void spawnBox()
    {
        Vector3 spawnPos=spawnPoint.position;
        spawnPos.x=Random.Range(-maxX, maxX);
        Instantiate(box,spawnPos,Quaternion.identity);
        score++;
        scoreText.text=score.ToString();
    }
}
