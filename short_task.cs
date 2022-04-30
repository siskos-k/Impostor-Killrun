using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class short_task : MonoBehaviour
{
   [SerializeField] private string selectableTag = "Selectable";
   [SerializeField] private Material highlightMaterial;
   [SerializeField] private Material defaultMaterial;
   [SerializeField] private Material highlightMaterial_skoup;
   [SerializeField] private string skoupidiaTag = "Skoupidia";
   [SerializeField] private string gasTag = "gas";
   

   public GameObject videoPlayer;
   public GameObject Skoupidia;
   public GameObject gass;
  // public int timeToStop;
    
    private Transform _selection;
    public bool doing_task;
    public PlayerMovement Player;
    //private Transform _skoupidia;
    // Update is called once per frame
    private void Start(){
        videoPlayer.SetActive(false);
        Skoupidia.SetActive(false);
        gass.SetActive(false);
    }
    private void Update()
    {
        if(!doing_task && !PauseMenu.GameIsPaused){ 

        if (_selection != null){
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }


        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){

        var selection = hit.transform;

        if (selection.CompareTag(selectableTag))
        { 
            OnMouseOver1();
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                selectionRenderer.material = highlightMaterial;
            }
        _selection = selection;
        }   

         
        if (selection.CompareTag(skoupidiaTag))
        { 
            OnMouseOver2();
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                selectionRenderer.material = highlightMaterial_skoup;
            }
        _selection = selection;
        }   

         if (selection.CompareTag(gasTag))
        { 
            OnMouseOver3();
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                selectionRenderer.material = highlightMaterial_skoup;
            }
        _selection = selection;
        }   


           
        }
    }
     void OnMouseOver1()
     {
            if(Input.GetMouseButtonUp(0))
                {
                doing_task = true;
                Player.speed=0f;
                videoPlayer.SetActive(true);
                //Debug.Log("Downloading...");
                StartCoroutine(Test());
                }
    }
    void OnMouseOver2()
     {
            if(Input.GetMouseButtonUp(0))
                {
                doing_task = true;
                Player.speed=0f;
                Skoupidia.SetActive(true);
                //Debug.Log("Downloading...");
                StartCoroutine(Test());
                }
    }
    void OnMouseOver3()
     {
            if(Input.GetMouseButtonUp(0))
                {
                doing_task = true;
                Player.speed=0f;
                gass.SetActive(true);
                //Debug.Log("Downloading...");
                StartCoroutine(Test());
                }
    }
    }
    IEnumerator Test(){
        yield return new WaitForSeconds (10);
        //Debug.Log("Wait is over");
        doing_task = false;
        videoPlayer.SetActive(false);
        Skoupidia.SetActive(false);
        gass.SetActive(false);
        Player.speed=5f;
    }

}















