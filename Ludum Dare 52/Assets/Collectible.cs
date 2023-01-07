using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    [SerializeField]
    private CollectibleSO collectibleConfig;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        
        spriteRenderer.sprite = collectibleConfig.collectibleSprite;
    }

	private void OnTriggerEnter2D(Collider2D collider)
	{
        IncreaseScore(1, collider);
        gameObject.SetActive(false);

	}

    private void IncreaseScore(int value, Collider2D other)
	{
        other.gameObject.GetComponent<Player>().score += value;
	}
}
