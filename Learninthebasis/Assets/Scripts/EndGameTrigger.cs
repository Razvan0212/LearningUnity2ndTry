using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{
    public GameManager gm;
    private void OnTriggerEnter()
    {
        gm.LevelComplete();
    }
}
