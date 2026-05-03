using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Assertions;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance{get;private set;}
    

    private void Awake(){
        if (Instance==null){
            Instance=this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        Destroy(gameObject);
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitialiseTerrain()
    {
        //myTerrain=new List<Terrain>();
        //myTerrain.Add(Grassland.Create("Happy Meadows"));
        
        //Assert.AreEqual(10,myTerrain.Count);
    }
}
