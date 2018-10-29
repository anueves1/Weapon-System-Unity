using UnityEngine;
using System.Collections;

public class playAllAnimations : MonoBehaviour {
	//it'll be re-written to use arrays when weapon list grows bigger
	public GameObject arms1; //1 is m9 here, 2 is tt, 3 is mag44
	public GameObject arms2;
	public GameObject arms3;
	public GameObject weapon1;
	public GameObject weapon2;
	public GameObject weapon3;
	//public bool[] animPlaying;
	//private int animAmount = 6;
	//private int playingAnimIndex = -1;
	public Camera mainCameraGO;
	public GameObject mainCameraSnapObject1;
	public GameObject mainCameraSnapObject2;
	public GameObject mainCameraSnapObject3;
	public float cameraNormalFov = 60f;
	public float cameraZoomFov = 24f;
	public float cameraNearClipping = 0.1f;
	// Use this for initialization
	void Start () {
//		animPlaying = new bool[animAmount];
//		for (int x=0; x> animAmount; x++)
//		{
//
//			animPlaying[x] = false;
//
//		}
		mainCameraGO = Camera.main;
		mainCameraSnapObject1 = GameObject.FindGameObjectWithTag("mainCameraSnapObject1");
		mainCameraSnapObject2 = GameObject.FindGameObjectWithTag("mainCameraSnapObject2");
		mainCameraSnapObject3 = GameObject.FindGameObjectWithTag("mainCameraSnapObject3");
		mainCameraGO.transform.position = mainCameraSnapObject1.transform.position;
		mainCameraGO.transform.rotation = mainCameraSnapObject1.transform.rotation;
		mainCameraGO.nearClipPlane = cameraNearClipping;

	}
	
	// Update is called once per frame
	void Update () {



	}




	public void playReload()
	{
		arms1.GetComponent<Animation>().Play("M9-Reload");
		weapon1.GetComponent<Animation>().Play("M9-Reload", PlayMode.StopAll);
		arms2.GetComponent<Animation>().Play("TT-Reload");
		weapon2.GetComponent<Animation>().Play("TT-Reload", PlayMode.StopAll);
		arms3.GetComponent<Animation>().Play("44-Reload");
		weapon3.GetComponent<Animation>().Play("44-Reload", PlayMode.StopAll);



		mainCameraGO.fieldOfView = cameraNormalFov;
	}
	public void playFire()
	{
		arms1.GetComponent<Animation>().Play("M9-Fire");
		weapon1.GetComponent<Animation>().Play("M9-Fire", PlayMode.StopAll);
		arms2.GetComponent<Animation>().Play("TT-Fire");
		weapon2.GetComponent<Animation>().Play("TT-Fire", PlayMode.StopAll);
		arms3.GetComponent<Animation>().Play("44-Fire");
		weapon3.GetComponent<Animation>().Play("44-Fire", PlayMode.StopAll);

		mainCameraGO.fieldOfView = cameraNormalFov;
	}

	public void playIdle()
	{
		arms1.GetComponent<Animation>().Play("M9-Idle");
		weapon1.GetComponent<Animation>().Play("M9-Idle", PlayMode.StopAll);
		arms2.GetComponent<Animation>().Play("TT-Idle");
		weapon2.GetComponent<Animation>().Play("TT-Fire", PlayMode.StopAll);
		weapon2.GetComponent<Animation>().Stop();
		arms3.GetComponent<Animation>().Play("44-Idle");
		weapon3.GetComponent<Animation>().Play("44-Idle", PlayMode.StopAll);

		mainCameraGO.fieldOfView = cameraNormalFov;
	}

	public void playSprint()
	{
		arms1.GetComponent<Animation>().Play("M9-Sprint");
		weapon1.GetComponent<Animation>().Play("M9-Idle", PlayMode.StopAll);
		arms2.GetComponent<Animation>().Play("TT-Sprint");
		weapon2.GetComponent<Animation>().Play("TT-Fire", PlayMode.StopAll);
		weapon2.GetComponent<Animation>().Stop();
		arms3.GetComponent<Animation>().Play("44-Sprint");
		weapon3.GetComponent<Animation>().Play("44-Idle", PlayMode.StopAll);

		mainCameraGO.fieldOfView = cameraNormalFov;
	}

	public void playADSFire()
	{
		arms1.GetComponent<Animation>().Play("M9-ADS-Fire");
		weapon1.GetComponent<Animation>().Play("M9-Fire", PlayMode.StopAll);
		arms2.GetComponent<Animation>().Play("TT-ADS-Fire");
		weapon2.GetComponent<Animation>().Play("TT-Fire", PlayMode.StopAll);
		arms3.GetComponent<Animation>().Play("44-ADS-Fire");
		weapon3.GetComponent<Animation>().Play("44-Fire", PlayMode.StopAll);

		mainCameraGO.fieldOfView = cameraZoomFov;
	}
	public void playADSIdle()
	{
		arms1.GetComponent<Animation>().Play("M9-ADS-Idle");
		weapon1.GetComponent<Animation>().Play("M9-Idle", PlayMode.StopAll);
		arms2.GetComponent<Animation>().Play("TT-ADS-Idle");
		weapon2.GetComponent<Animation>().Play("TT-Fire", PlayMode.StopAll);
		weapon2.GetComponent<Animation>().Stop();
		arms3.GetComponent<Animation>().Play("44-ADS-Idle");
		weapon3.GetComponent<Animation>().Play("44-Idle", PlayMode.StopAll);

		mainCameraGO.fieldOfView = cameraZoomFov;
	}

	public void playNothing()
	{
		arms1.GetComponent<Animation>().Stop();
		weapon1.GetComponent<Animation>().Stop();
		arms2.GetComponent<Animation>().Stop();
		weapon2.GetComponent<Animation>().Stop();
		arms3.GetComponent<Animation>().Stop();
		weapon3.GetComponent<Animation>().Stop();


		//mainCameraGO.fieldOfView = cameraNormalFov;

	}

	public void switch1()
	{
		mainCameraGO.transform.position = mainCameraSnapObject1.transform.position;
		mainCameraGO.transform.rotation = mainCameraSnapObject1.transform.rotation;


	}

	public void switch2()
	{
		mainCameraGO.transform.position = mainCameraSnapObject2.transform.position;
		mainCameraGO.transform.rotation = mainCameraSnapObject2.transform.rotation;
		
		
	}

	public void switch3()
	{
		mainCameraGO.transform.position = mainCameraSnapObject3.transform.position;
		mainCameraGO.transform.rotation = mainCameraSnapObject3.transform.rotation;
		
		
	}

	}

