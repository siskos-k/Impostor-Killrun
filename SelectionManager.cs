using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
   [SerializeField] private string selectableTag = "Selectable";
   [SerializeField] private Material longMaterial;
   [SerializeField] private Material defaultMaterial;
   [SerializeField] private Material shortMaterial;

   [SerializeField] private string scantag = "scan";
   [SerializeField] private string skoupidiaTag = "Skoupidia";
   [SerializeField] private string gasTag = "gas";
   [SerializeField] private string setNav = "nav";
   [SerializeField] private string cardd = "card";
   

   
//yellow is for long tasks, green is for short tasks

//We need distance Check 

//holly fuck this is gonna take forever

    //first row: task box
        //second row: video

    //DOWNLOAD-UPLOAD
    public GameObject DownWeap;
    public GameObject DownElec;
    public GameObject DownCom;
    public GameObject UploadBox;
    public GameObject videoPlayerbox;
        public GameObject videoPlayer;
    
    //TRASH
    public GameObject skoupidiaBox;
    public GameObject skoupidiaBox2;
        public GameObject Skoupidia;

    //GAS
    public GameObject GassBox1;
    public GameObject GassBoxUpper;
    public GameObject GassBox1Lower;
         public GameObject gass;

    //SCANMED
    public GameObject scanbox;
        public GameObject scan;
    
    //NAV
    public GameObject navbox;
        public GameObject nav;

    //SWIPE CARD
    public GameObject cardbox;
        public GameObject card;


    //This is the player    
   public GameObject Crewmate;
   
  // public int timeToStop;
  public int Tasks_Done; //UPDATE TASK BY TASK, INITIALIZE ON 0;

  //DISTANCES

  //skoupidia
  public float DistanceSkoupidia1;
  public float DistanceSkoupidia2;

  //download-upload
  public float DistanceDownCaf;
  public float DistanceDownCom;
  public float DistanceDownElec;
  public float DistanceDownWeap;
  public float DistanceUpload;

  //navigation
  public float DistanceNav;
  
  //card
  public float DistanceCard;

  //medbay
  public float DistanceMed;


    
    private Transform _selection;
    public bool doing_task;
    public bool CanDoDownload;
    public PlayerMovement Player;

    //private Transform _skoupidia;
    // Update is called once per frame

    private void Start(){
        videoPlayer.SetActive(false);
        Skoupidia.SetActive(false);
        scan.SetActive(false);
        card.SetActive(false);
        gass.SetActive(false);
        nav.SetActive(false);
    }

    private void Update()
    {
        //Debug.Log(DistanceSkoupidia);
        //DistanceDownload = Vector3.Distance(Task.transform.position,Crewmate.transform.position);  CHECK ONE BY ONE INDIVIDUALLY
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

            //DOWNLOAD CHECK
            DistanceDownCaf = Vector3.Distance(videoPlayerbox.transform.position,Crewmate.transform.position);
            DistanceDownCom = Vector3.Distance(DownCom.transform.position,Crewmate.transform.position);
            DistanceDownElec= Vector3.Distance(DownElec.transform.position,Crewmate.transform.position);
            DistanceUpload  = Vector3.Distance(UploadBox.transform.position,Crewmate.transform.position);
            DistanceDownWeap= Vector3.Distance(DownWeap.transform.position, Crewmate.transform.position);

            if (DistanceDownWeap< 2.3 || DistanceDownElec < 2.3 || DistanceUpload < 2.3 || DistanceDownCom < 2.3 || DistanceDownCaf < 2.3)
             {
                CanDoDownload = true;
             } 
             
             else CanDoDownload = false;

            if (selection.CompareTag(selectableTag))//add distance check
            { 
                OnMouseOver1();
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = longMaterial;
                }
                _selection = selection;
                }   
            //SKOUPIDIA CHECK
            DistanceSkoupidia1 = Vector3.Distance(skoupidiaBox.transform.position,Crewmate.transform.position);
            DistanceSkoupidia2 = Vector3.Distance(skoupidiaBox2.transform.position,Crewmate.transform.position);

            if (selection.CompareTag(skoupidiaTag))//add distance check
            { 
                OnMouseOver2();
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = longMaterial;
                }
            _selection = selection;
            }   
            //DistanceGasMain = Vector3.Distance(GassBox1)                                     TODO ADD ALL SKOUPIDIA
            if (selection.CompareTag(gasTag))//add distance check
            { 
                OnMouseOver3();
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = shortMaterial;
                }
            _selection = selection;
            }   
            DistanceNav = Vector3.Distance(navbox.transform.position, Crewmate.transform.position);
            if (selection.CompareTag(setNav))//add distance check
            { 
                OnMouseOver4();
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = shortMaterial;
                }
            _selection = selection;
            }

            DistanceCard = Vector3.Distance(cardbox.transform.position, Crewmate.transform.position);
            if (selection.CompareTag(cardd))//add distance check
            {
                OnMouseOver5();
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = shortMaterial;
                }
            _selection = selection;
            }

            DistanceMed = Vector3.Distance(scanbox.transform.position,Crewmate.transform.position);
            if (selection.CompareTag(scantag))//add distance check
            {
                OnMouseOver6();
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    selectionRenderer.material = longMaterial;
                }
            _selection = selection;
            }
            
        
        void OnMouseOver1()
            {
                if(Input.GetMouseButtonUp(0) && CanDoDownload)
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
                if(Input.GetMouseButtonUp(0)  && (DistanceSkoupidia2 < 2 || DistanceSkoupidia1<3) )
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
        void OnMouseOver4()//navigation
            {
                if(Input.GetMouseButtonUp(0) && DistanceNav < 3)
                    {
                    doing_task = true;
                    Player.speed=0f;
                    nav.SetActive(true);
                    //Debug.Log("Downloading...");
                    StartCoroutine(Test());
                    }   
            }
        void OnMouseOver5()//card
            {
                if(Input.GetMouseButtonUp(0) && DistanceCard < 2)
                    {
                    doing_task = true;
                    Player.speed=0f;
                    card.SetActive(true);
                    //Debug.Log("Downloading...");
                    StartCoroutine(Short());
                    } 
            }
        void OnMouseOver6()//sacn
            {
                if(Input.GetMouseButtonUp(0) && DistanceMed < 1.32)
                    {
                    doing_task = true;
                    Player.speed=0f;
                    scan.SetActive(true);
                    //Debug.Log("Downloading...");
                    StartCoroutine(Test());
                    } 
            }

            IEnumerator Test(){
                yield return new WaitForSeconds (10);
                //Debug.Log("Wait is over");
                doing_task = false;
                videoPlayer.SetActive(false);
                Skoupidia.SetActive(false);
                gass.SetActive(false);
                scan.SetActive(false);
                nav.SetActive(false);
                Player.speed=5f;
                }

            IEnumerator Short(){
                yield return new WaitForSeconds (5);
                //Debug.Log("Wait is over");
                doing_task = false;
                videoPlayer.SetActive(false);
                Skoupidia.SetActive(false);
                gass.SetActive(false);
                card.SetActive(false);
                Player.speed=5f;
                }

            }
        }
    }
}