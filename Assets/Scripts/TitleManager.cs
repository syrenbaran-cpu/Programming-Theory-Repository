using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Assertions;
using UnityEngine.UI;
using TMPro;
using static TMPro.TMP_Dropdown;
using Assets.Scripts.my.animals;
using Assets.Scripts.my.terrain;
using UnityEngine.SceneManagement;


public class TitleManager : MonoBehaviour
{
    public static TitleManager Instance{get;private set;}
    private TMP_Dropdown animalsDropdown;
    private TMP_InputField inputName;
    private List<TerrainType> myTerrain;
    public Animal SelectedAnimal {  get; private set; }

    private void Awake(){
        
        
    }
    private void DuplicateCheck()
    {
        if (Instance != null)
        {
            Destroy(Instance.gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DuplicateCheck();
        //animalsDropdown = GameObject.Find("AnimalsDropdown");
        /*
        Component[] components = GameObject.Find("TitleScreen").GetComponents<Component>();
        for (int i = 0; i < components.Length; i++)
        {
            Component comp = components[i];
            Debug.Log("Component " + i + ": " + comp.GetType().Name + ", " + comp.name);
            //Debug.Log("animalsDropdown: " + GameObject.Find("TitleScreen").GetComponent<Dropdown>().name);
        }
        Debug.Log("Childen of TitleScreen:");
        components = GameObject.Find("TitleScreen").GetComponentsInChildren<Component>();
        for (int i = 0; i < components.Length; i++)
        {
            Component comp = components[i];
            Debug.Log("Component " + i + ": " + comp.GetType().Name + ", " + comp.name);
            //Debug.Log("animalsDropdown: " + GameObject.Find("TitleScreen").GetComponent<Dropdown>().name);
        }

        
        Debug.Log("animalsDropdown: " + animalsDropdown.name);
        */
        inputName = GameObject.Find("TitleScreen").GetComponentInChildren<TMP_InputField>();
        InitialiseAnimalsDropdown();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       
    
    private void InitialiseAnimalsDropdown()
    {
        animalsDropdown = GameObject.Find("TitleScreen").GetComponentInChildren<TMP_Dropdown>();
        animalsDropdown.options.Clear();
        animalsDropdown.options.Add(new TMP_Dropdown.OptionData("Dog"));
        animalsDropdown.options.Add(new TMP_Dropdown.OptionData("Cat"));
        animalsDropdown.options.Add(new TMP_Dropdown.OptionData("Bunny"));
        animalsDropdown.options.Add(new TMP_Dropdown.OptionData("Duck"));
        animalsDropdown.options.Add(new TMP_Dropdown.OptionData("Dove"));
        animalsDropdown.options.Add(new TMP_Dropdown.OptionData("Monkey"));
        animalsDropdown.options.Add(new TMP_Dropdown.OptionData("Turtle"));
    }
    public void StartButtonPressed() {
        string selectedAnimal = animalsDropdown.options[animalsDropdown.value].text;
        string name = inputName.text;
        Debug.Log("Selected Animal: " + selectedAnimal);
        Debug.Log("Entered Name: " + name);
        if ("".Equals(name))
        {
            Debug.Log("Please enter a name for your animal.");
            inputName.placeholder.GetComponent<TextMeshProUGUI>().text = "Please enter a name!";
            inputName.placeholder.GetComponent<TextMeshProUGUI>().color = Color.red;
            return;
        }
        if ("".Equals(selectedAnimal))
        {
            Debug.Log("Please select an animal.");
            return;
        }
        
        switch (selectedAnimal)
        {
            case "Dog":
                Dog dog = Dog.Create(name);
                SelectedAnimal = dog;
                Debug.Log("Created a Dog named " + dog.name);
                break;
            case "Cat":
                Cat cat = Cat.Create(name);
                SelectedAnimal = cat;
                Debug.Log("Created a Cat named " + cat.name);
                break;
            case "Bunny":
                Bunny bunny = Bunny.Create(name);
                SelectedAnimal= bunny;
                Debug.Log("Created a Bunny named " + bunny.name);
                break;
            case "Duck":
                Duck duck = Duck.Create(name);
                SelectedAnimal = duck;
                Debug.Log("Created a Duck named " + duck.name);
                break;
            case "Dove":
                Dove dove = Dove.Create(name);
                SelectedAnimal = dove;
                Debug.Log("Created a Dove named " + dove.name);
                break;
            case "Monkey":
                Monkey monkey = Monkey.Create(name);
                SelectedAnimal = monkey;
                Debug.Log("Created a Monkey named " + monkey.name);
                break;
            case "Turtle":
                Turtle turtle = Turtle.Create(name);
                SelectedAnimal = turtle;
                Debug.Log("Created a Turtle named " + turtle.name);
                break;
            default:
                Debug.LogError("Unknown animal selected: " + selectedAnimal);
                return;
        }
        SceneManager.LoadScene(1);
        // Here you can add code to transition to the next scene or start the game with the selected animal and name.
    }
}
