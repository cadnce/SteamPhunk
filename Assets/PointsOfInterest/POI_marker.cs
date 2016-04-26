using UnityEngine;
using System.Collections;

public class POI_marker : MonoBehaviour {
	public string title;
	public string body;
	public float longtitude;
	public float latitude;

	// Use this for initialization
	void Start () {
		title = "Bradbury Landing";
		body = "Bradbury Landing is the landing site for the Curiosity rover within Gale Crater. It is named after writer Ray Bradbury and is located in Aeolis Palus, a flat plain between Gale Crater's northern rim and central peak. Aeolis Palus lies in what appears to be the wash debris of Peace Vallis, an outflow channel flowing down the slope of Gale Crater's rim. Shortly after landing, Curiosity found evidence supporting this view in the form of rock outcrops in the immediate area composed of conglomerated fluvial sediments, the type of formation that would form in a vigorously flowing stream";
		longtitude = 137.4416334989196f;
		latitude = -4.5894669521344875f;
	}

	// Update is called once per f
	void Update () {
	
	}
}
