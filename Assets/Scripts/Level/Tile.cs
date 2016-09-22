using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	// Public variables
	//------------------
	public static float stepHeight = 0.25f;
	public GameObject content;
	[HideInInspector] public Tile prev;
	[HideInInspector] public int distance;

	// Private members
	//-----------------
	public Point pos;
	public int height;

	// Properties
	//------------
	public Vector3 center { get { return new Vector3(pos.x, height * stepHeight, pos.y); }}


	//
	// Unity method overrides
	//

	void Start() {
	
	}
	
	void Update() {
	
	}


	//
	// General methods
	//

	void Match() {
		transform.localPosition = new Vector3( pos.x, height * stepHeight / 2f, pos.y );
		transform.localScale = new Vector3(1, height * stepHeight, 1);
	}

	public void Grow() {
		height++;
		Match();
	}

	public void Shrink() {
		height--;
		Match ();
	}

	public void Load (Point p, int h) {
		pos = p;
		height = h;
		Match();
	}

	public void Load (Vector3 v) {
		Load (new Point((int)v.x, (int)v.z), (int)v.y);
	}
}
