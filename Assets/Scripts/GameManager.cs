using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Assertions;
using UnityEngine.UI;
using TMPro;
using static TMPro.TMP_Dropdown;
using Assets.Scripts.my.animals;
using Assets.Scripts.my.terrain;
using Assets.Scripts.my.movement;


public class GameManager : MonoBehaviour
{
    private Animal selectedAnimal;    
    public TMP_Dropdown locationDropdown;
    public TMP_Text outputArea;
    private List<TerrainType> myTerrain;
    public int maxTextLength = 500; // Maximum length of the output text


    private void Awake(){
       
        
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectedAnimal=TitleManager.Instance.SelectedAnimal;
        InitialiseTerrain();
        List<TerrainType> possibleStartingPositions = new List<TerrainType>();
        foreach (TerrainType terrain in myTerrain)
        {
            if (selectedAnimal.CanMoveTo(terrain))
            {
                possibleStartingPositions.Add(terrain);
            }
        }
        int randomIndex = Random.Range(0, possibleStartingPositions.Count);
        TerrainType startingTerrain = possibleStartingPositions[randomIndex];
        selectedAnimal.CurrentTerrain = startingTerrain;
        createOpeningMessage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void createOpeningMessage()
    {
        string message = $"Welcome to the game {selectedAnimal.name}! You are a {selectedAnimal.GetType().Name} starting in {selectedAnimal.CurrentTerrain.name}.";
        outputArea.text = message;  
    }
       
    private void InitialiseTerrain()
    {
        myTerrain=new List<TerrainType>();
        myTerrain.Add(Grassland.Create("Happy Meadows", "A beautiful grassy area."));
        myTerrain.Add(TreeType.Create("Old Willow", "A large, ancient willow tree."));
        myTerrain.Add(WaterBody.Create("Blue Lake", "A serene blue lake."));
        myTerrain.Add(Grassland.Create("Sunny Fields", "Fields bathed in sunlight."));
        myTerrain.Add(TreeType.Create("Big Pine Tree", "A tall pine tree."));
        myTerrain.Add(WaterBody.Create("Crystal River", "A clear and refreshing river."));
        myTerrain.Add(Grassland.Create("Green Pastures", "Lush green fields."));
        myTerrain.Add(Sky.Create("Cloudy Sky", "A sky filled with clouds."));
        //Assert.AreEqual(10,myTerrain.Count);
        foreach (TerrainType terrain in myTerrain)
        {
            locationDropdown.options.Add(new OptionData(terrain.name));
        }
    }

    public void MoveToLocation()
    {
        int selectedIndex = locationDropdown.value;
        TerrainType selectedTerrain = myTerrain[selectedIndex];
        if (selectedTerrain == selectedAnimal.CurrentTerrain) {
            AppendOutputText($"You are already in {selectedTerrain.name}.");
            return;
        }
        AppendOutputText($"You are {selectedAnimal.getLocomotionForCurrentTerrain().type} through {selectedAnimal.CurrentTerrain.name}"
            +$" towards {selectedTerrain.name}.");
        Locomotion locomotion = selectedAnimal.getLocomotionForTerrain(selectedTerrain);
        if (locomotion == null) {
            AppendOutputText($"You cannot move to {selectedTerrain.name}. You stay in {selectedAnimal.CurrentTerrain.name} because you cannot go there.");
        } else
        {
            selectedAnimal.CurrentTerrain = selectedTerrain;
            AppendOutputText($"The {selectedAnimal.GetType().Name} is {locomotion.type} to {selectedTerrain.name}.");
                
        }
    }

    private void AppendOutputText(string text)
    {
        string previousText = outputArea.text;
        previousText+= " " + text;
        while (previousText.Length > maxTextLength) {
            int firstSpaceIndex = previousText.IndexOf(' ');
            if (firstSpaceIndex == -1) break;
            previousText = previousText[(firstSpaceIndex + 1)..];
        }
        outputArea.text = previousText;
    }

    public void CreateNoise()
    {
        string noise = selectedAnimal.makeNoise();
        AppendOutputText(noise);
    }
    public void LookAround()
    {
        string description = selectedAnimal.CurrentTerrain.description;
        AppendOutputText(description);
    }

    public void BackToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    
    
}
