using UnityEngine;
using System.Collections;

public class DungeonGenerator : MonoBehaviour {
    public float seed = 12939123;
    public float floorLevel;
    private float levelSize;
    public float levelDensity;
    public float levelRoomSize;

	// Use this for initialization
	void Start () {
        GridGeneration();
	}
	
    void GridGeneration()
    {
        levelSize = seed % 5;
        
    }
}
