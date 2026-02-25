using TMPro;
using UnityEngine;

public class HPChcker : MonoBehaviour
{
    public static HPChcker Instance;

    public TMP_Text PlayerHPText;
    public TMP_Text OpponentHPText;

    public string HPtext = "HP: ";
    public int playerHP;
    public int opponentHP;

    public GameObject Player;
    public GameObject Opponent;
    private void Awake()
    {
        // If another instance already exists, destroy this one
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        // Optional: Uncomment if you want it across scenes
        // DontDestroyOnLoad(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHP = 100;
        opponentHP = 100;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHPText.text = HPtext + playerHP;
        OpponentHPText.text = HPtext + opponentHP;

        if(playerHP <= 0)
        {
            Destroy(Player);
        }
        if (opponentHP <= 0)
        {
            Destroy(Opponent);
        }
    }
}
