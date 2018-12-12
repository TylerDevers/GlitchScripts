using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

	[SerializeField] GameObject cactusPrefab;

    private void OnMouseDown()
	{
		SpawnDefender(GetSquareClicked());
	}

	//find mouse click location
	private Vector2 GetSquareClicked()
	{
		Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
		Vector2 gridPos = SnapToGrid(worldPos);
		return gridPos;
	}

	private Vector2 SnapToGrid(Vector2 rawWorldPos)
	{
		float newX = Mathf.RoundToInt(rawWorldPos.x);
		float newY = Mathf.RoundToInt(rawWorldPos.y);
		Vector2 gridPos = new Vector2(newX, newY);
		return gridPos;
	}

	private void SpawnDefender(Vector2 worldPos)
	{
		GameObject newDefender = Instantiate(cactusPrefab, worldPos, Quaternion.identity) as GameObject;
		Debug.Log(worldPos);
		
	}
}
