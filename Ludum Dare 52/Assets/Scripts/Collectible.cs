using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    [SerializeField]
    private CollectibleSO collectibleConfig;
    private GameObject[] collectibles;
    private string tagName = "Collectible";
    private bool collectible = true;

    void Start()
    {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = collectibleConfig.collectibleSprite;
        collectibles = GameObject.FindGameObjectsWithTag(tagName);
    }

	private void OnTriggerEnter2D(Collider2D collider)
	{
        if (collectible == false)
            return;

        IncreaseScore(1, collider);
        gameObject.GetComponent<SpriteRenderer>().sprite = null;
        collectible = false;
        GameManager.Instance.collectibleCount += 1;
        if (collectibles.Length == GameManager.Instance.collectibleCount)
		{
            foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player"))
            {
                player.GetComponent<PlayerMovement>().canMove = false;
            }
            StartCoroutine(NextLevel());
        }
	}

    private void IncreaseScore(int value, Collider2D other)
	{
        other.gameObject.GetComponent<Player>().score += value;
	}

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(1f);
        ScenesManager.Instance.LoadNextScene();
    }

}
