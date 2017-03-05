//using UnityEngine;
//using System.Collections;
//
//public class flaregun : MonoBehaviour {
//	
//	public Rigidbody flareBullet;
//	public Transform barrelEnd;
//	public GameObject muzzleParticles;
//	public AudioClip flareShotSound;
//	public AudioClip noAmmoSound;	
//	public AudioClip reloadSound;	
//	public int bulletSpeed = 2000;
//	public int maxSpareRounds = 5;
//	public int spareRounds = 3;
//	public int currentRound = 0;
//	
//	
//
//
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () 
//	{
//		
//		if(Input.GetButtonDown("Fire1") && !animation.isPlaying)
//		{
//			if(currentRound > 0){
//				Shoot();
//			}else{
//				animation.Play("noAmmo");
//				audio.PlayOneShot(noAmmoSound);
//			}
//		}
//		if(Input.GetKeyDown(KeyCode.R) && !animation.isPlaying)
//		{
//			Reload();
//			
//		}
//	
//	}
//	
//	void Shoot()
//	{
//			currentRound--;
//		if(currentRound <= 0){
//			currentRound = 0;
//		}
//		
//		
//		
//			animation.CrossFade("Shoot");
//			audio.PlayOneShot(flareShotSound);
//		
//			
//			Rigidbody bulletInstance;			
//			bulletInstance = Instantiate(flareBullet,barrelEnd.position,barrelEnd.rotation) as Rigidbody; //INSTANTIATING THE FLARE PROJECTILE
//			
//			
//			bulletInstance.AddForce(barrelEnd.forward * bulletSpeed); //ADDING FORWARD FORCE TO THE FLARE PROJECTILE
//			
//			Instantiate(muzzleParticles, barrelEnd.position,barrelEnd.rotation);	//INSTANTIATING THE GUN'S MUZZLE SPARKS	
//		
//	}
//	
//	void Reload()
//	{
//		if(spareRounds >= 1 && currentRound == 0){
//			audio.PlayOneShot(reloadSound);			
//			spareRounds--;
//			currentRound++;
//			animation.CrossFade("Reload");
//		}
//		
//	}
//}
