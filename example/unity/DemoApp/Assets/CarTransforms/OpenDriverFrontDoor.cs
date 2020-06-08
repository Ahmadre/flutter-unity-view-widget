using UnityEngine;
public class OpenDriverFrontDoor : MonoBehaviour
{    
    GameObject front_left_door_alcantara;
    Animator front_left_door_alcantara_ANIMATOR;

    GameObject front_left_door_body;
    Animator front_left_door_body_ANIMATOR;

    GameObject front_left_door_cloth_pivot;
    Animator front_left_door_cloth_pivot_ANIMATOR;

    GameObject front_left_door_grille;
    Animator front_left_door_grille_ANIMATOR;

    GameObject front_left_door_plastic_1;
    Animator front_left_door_plastic_1_ANIMATOR;

    GameObject front_left_door_plastic_2;
    Animator front_left_door_plastic_2_ANIMATOR;

    GameObject front_left_door_plastic_3_pivot;
    Animator front_left_door_plastic_3_pivot_ANIMATOR;

    GameObject front_left_door_plastic_4_pivot;
    Animator front_left_door_plastic_4_pivot_ANIMATOR;

    GameObject front_left_door_reflection;
    Animator front_left_door_reflection_ANIMATOR;

    GameObject front_left_door_rubber;
    Animator front_left_door_rubber_ANIMATOR;

    GameObject front_left_door_shadow;
    Animator front_left_door_shadow_ANIMATOR;

    GameObject front_left_door_window;
    Animator front_left_door_window_ANIMATOR;

    // Awake is called before Start
    void Awake()
    {
        front_left_door_alcantara = GameObject.Find("front_left_door_alcantara");
        front_left_door_body = GameObject.Find("front_left_door_body");
        front_left_door_cloth_pivot = GameObject.Find("front_left_door_cloth_pivot");
        front_left_door_grille = GameObject.Find("front_left_door_grille");
        front_left_door_plastic_1 = GameObject.Find("front_left_door_plastic_1");
        front_left_door_plastic_2 = GameObject.Find("front_left_door_plastic_2");
        front_left_door_plastic_3_pivot = GameObject.Find("front_left_door_plastic_3_pivot");
        front_left_door_plastic_4_pivot = GameObject.Find("front_left_door_plastic_4_pivot");
        front_left_door_reflection = GameObject.Find("front_left_door_reflection");
        front_left_door_rubber = GameObject.Find("front_left_door_rubber");
        front_left_door_shadow = GameObject.Find("front_left_door_shadow");
        front_left_door_window = GameObject.Find("front_left_door_window");

        front_left_door_alcantara_ANIMATOR = front_left_door_alcantara.GetComponent<Animator>();
        front_left_door_body_ANIMATOR = front_left_door_body.GetComponent<Animator>();
        front_left_door_cloth_pivot_ANIMATOR = front_left_door_cloth_pivot.GetComponent<Animator>();
        front_left_door_grille_ANIMATOR = front_left_door_grille.GetComponent<Animator>();
        front_left_door_plastic_1_ANIMATOR = front_left_door_plastic_1.GetComponent<Animator>();
        front_left_door_plastic_2_ANIMATOR = front_left_door_plastic_2.GetComponent<Animator>();
        front_left_door_plastic_3_pivot_ANIMATOR = front_left_door_plastic_3_pivot.GetComponent<Animator>();
        front_left_door_plastic_4_pivot_ANIMATOR = front_left_door_plastic_4_pivot.GetComponent<Animator>();
        front_left_door_reflection_ANIMATOR = front_left_door_reflection.GetComponent<Animator>();
        front_left_door_rubber_ANIMATOR = front_left_door_rubber.GetComponent<Animator>();
        front_left_door_shadow_ANIMATOR = front_left_door_shadow.GetComponent<Animator>();
        front_left_door_window_ANIMATOR = front_left_door_window.GetComponent<Animator>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// Flutter Bridging method to animate the drivers front door (open/close)
    public void DoorOpened(string state)
    {
        front_left_door_alcantara_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_left_door_body_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_left_door_cloth_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_left_door_grille_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_left_door_plastic_1_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_left_door_plastic_2_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_left_door_plastic_3_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_left_door_plastic_4_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_left_door_reflection_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_left_door_rubber_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_left_door_shadow_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_left_door_window_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
    }
}
