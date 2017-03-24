using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridCanvas : MonoBehaviour {
    public Space[,] grid = new Space[10, 10]; // A 10 x 10 array of spaces

    // Constructor
    public gridCanvas() {
        // Initialize array with spaces
        float currentSpacePosX = -245f;
        float currentSpacePosY = 245f;
        for(int x = 0; x < 10; x++) {
            for(int y = 0; y < 10; y++) {
                grid[x, y] = new Space();
                // TODO : assign positions x and y to the newly created space
            }
        }
    }
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}