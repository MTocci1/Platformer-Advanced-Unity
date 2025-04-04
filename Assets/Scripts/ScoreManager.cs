using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int progressAmount = 0;
    public Slider progressSlider;

    public static ScoreManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        progressSlider.value = 0;
        Gem.OnGemCollect += IncreaseProgressAmount;
    }

    void IncreaseProgressAmount(int amount)
    {
        progressAmount += amount;
        progressSlider.value = progressAmount;

        if (progressAmount >= 100)
        {
            // Level Complete
            Debug.Log("Level Complete!");
        }
    }
}
