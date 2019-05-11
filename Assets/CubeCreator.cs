using UnityEngine;
using System.Collections;

public class CubeCreator : MonoBehaviour {

    //private CharacterController2D _controller;
    //private Animator _animator;

    private float y_old;
    
	
	double[,] ServicePoint = new double[10,9];
	
	
	byte [,] spectrum_palette = new byte [18,3] 
	{
    {0, 0, 0 } ,  // NEGRO, 0
    {0, 0, 205} , // AZUL, 1
    {205, 0, 0,}, // ROJO, 2
	{205,0,205}, // MAGENTA, 3
	{0,205,0}, // GREEN, 4
	{0,205,205}, // CYAN, 5
	{205,205,0}, // YELLOW, 6
	{205,205,205}, // WHITE ,7 
	{205,205,205}, // WHITE ,8
	{205,205,205}, // WHITE ,9 
    {0, 0, 0 } ,  // NEGRO, 10
    {0, 0, 255} , // AZUL, 11
    {255, 0, 0,}, // ROJO, 12
	{255,0,255}, // MAGENTA, 13
	{0,255,0}, // GREEN, 14
	{0,255,255}, // CYAN, 15
	{255,255,0}, // YELLOW, 16
	{255,255,255} // WHITE ,17 	
	};
		
	int color = 6;
	Font myFont;
	
	// Use this for initialization
	void Start () 
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(transform.position.x, transform.position.y - 1f - 1.7f, transform.position.z);
		
		 // Load and set Font
	//	myFont = (Font)Resources.Load("retganon", typeof(Font));
		//myButtonStyle.font = myFont; 
   	}
	
	void OnGUI()
	{
//			myFont = (Font)Resources.Load("retganon", typeof(Font));

		GUI.skin.font = myFont;
     	GUILayout.Label( " Color Walker \n (c) 2015 October. Written by KMBR");		
	}
 
	// Update is called once per frame
	void Update () 
    {
        float falling;
        falling = (y_old - transform.position.y) / Time.deltaTime;
        if (falling>6)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(transform.position.x, transform.position.y -1f - 1.7f, transform.position.z);
				cube.renderer.material.color = new Color32 (spectrum_palette[color,0],spectrum_palette[color,1],spectrum_palette[color,2],1);				
            }
        y_old = transform.position.y;        
		
		
		if (Input.GetKeyDown("0"))
		{
			color = 0;
		}		
		
		if (Input.GetKeyDown("1"))
		{
			if (color==11) color = 1;
				else color= 11;
		}
		
		if (Input.GetKeyDown("2"))
		{
			if (color==12) color = 2;
				else color= 12;
		}
				
		if (Input.GetKeyDown("3"))
		{
			if (color==13) color = 3;
				else color= 13;
		}
		
		if (Input.GetKeyDown("4"))
		{
			if (color==14) color = 4;
				else color= 14;
		}
		
		if (Input.GetKeyDown("5"))
		{
			if (color==15) color = 5;
				else color= 15;
		}
		if (Input.GetKeyDown("6"))
		{
			if (color==16) color = 6;
				else color= 16;
		}

		if (Input.GetKeyDown("7"))
		{
			if (color==17) color = 7;
				else color= 17;
		}
		Debug.Log ("Color="+color);
        // Debug.Log("Y= " + transform.position.y+" Time: "+Time.deltaTime+" FPS="+1/Time.deltaTime+" v="+falling);
	}
}
