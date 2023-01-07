using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    [SerializeField]
    private CollectibleSO collectibleConfig;
    private GameObject[] collectibles;
    private string tagName = "Collectible";

    void Start()
    {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = collectibleConfig.collectibleSprite;
        collectibles = GameObject.FindGameObjectsWithTag(tagName);
    }

	private void OnTriggerEnter2D(Collider2D collider)
	{
        IncreaseScore(1, collider);
        gameObject.SetActive(false);
        GameManager.Instance.collectibleCount += 1;
        if (collectibles.Length == GameManager.Instance.collectibleCount)
		{
            ScenesManager.Instance.LoadNextScene();
		}
	}

    private void IncreaseScore(int value, Collider2D other)
	{
        other.gameObject.GetComponent<Player>().score += value;
	}


}
