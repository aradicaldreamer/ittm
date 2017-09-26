using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCreme : MonoBehaviour {
	[SerializeField] GameObject cremeBallPrefab;
	bool isShaving;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckIfShaving();
	}

	void CheckIfShaving()
	{
		if (Input.GetMouseButton(0))
		{
			isShaving = true;
		}

		else isShaving = false;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == cremeBallPrefab.tag && isShaving)
		{
			print("destroy circle");
			Destroy(col.gameObject);
		}
	}
}
