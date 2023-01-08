using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerBehaviour : MonoBehaviour
{
	public Sprite closedSprite;
	private void OnTriggerEnter2D(Collider2D other)
	{
		foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player"))
		{
			player.GetComponent<PlayerMovement>().canMove = false;
		}
		Destroy(other.gameObject);
		GetComponentInParent<SpriteRenderer>().sprite = closedSprite;
		StartCoroutine(KillPlayer());
        
	}

	IEnumerator KillPlayer()
	{
		yield return new WaitForSeconds(1f);
        ScenesManager.Instance.ReloadScene();
	}
}
