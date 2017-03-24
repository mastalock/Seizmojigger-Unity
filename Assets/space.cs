using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class space : MonoBehaviour {
    [SerializeField]
    public GraboidType graboidType { get; set; }
    [SerializeField]
    public State state { get; set; }

    public space() {
        this.graboidType = GraboidType.None;
        this.state = State.Untried;
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
