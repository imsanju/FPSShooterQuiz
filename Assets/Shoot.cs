using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject shot;
	public Transform spawnPoint;
	public float fireRate;
	private float nextFire;
	// Use this for initialization
	void Start () {
	
	}

	void Update()
	{
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, spawnPoint.position, spawnPoint.rotation);
			var audio= GetComponent<AudioSource>();
			audio.Play();
		}
	}
}
