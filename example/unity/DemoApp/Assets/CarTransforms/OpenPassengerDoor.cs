using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPassengerDoor : MonoBehaviour
{
    /*********************************************
    * Passenger Front Door
    */
    GameObject front_right_door_alcantara;
    Animator front_right_door_alcantara_ANIMATOR;

    GameObject front_right_door_body;
    Animator front_right_door_body_ANIMATOR;

    GameObject front_right_door_cloth_pivot;
    Animator front_right_door_cloth_pivot_ANIMATOR;

    GameObject front_right_door_grille;
    Animator front_right_door_grille_ANIMATOR;

    GameObject front_right_door_plastic_1;
    Animator front_right_door_plastic_1_ANIMATOR;

    GameObject front_right_door_plastic_2;
    Animator front_right_door_plastic_2_ANIMATOR;

    GameObject front_right_door_plastic_3_pivot;
    Animator front_right_door_plastic_3_pivot_ANIMATOR;

    GameObject front_right_door_plastic_4_pivot;
    Animator front_right_door_plastic_4_pivot_ANIMATOR;

    GameObject front_right_door_reflection;
    Animator front_right_door_reflection_ANIMATOR;

    GameObject front_right_door_rubber;
    Animator front_right_door_rubber_ANIMATOR;

    GameObject front_right_door_shadow;
    Animator front_right_door_shadow_ANIMATOR;

    GameObject front_right_door_window;
    Animator front_right_door_window_ANIMATOR;
    /*********************************************
    * Passenger Front Door
    */

    void Awake() {
        initPassengerFrontDoor();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void initPassengerFrontDoor()
    {
        front_right_door_alcantara = GameObject.Find("front_right_door_alcantara");
        front_right_door_body = GameObject.Find("front_right_door_body");
        front_right_door_cloth_pivot = GameObject.Find("front_right_door_cloth_pivot");
        front_right_door_grille = GameObject.Find("front_right_door_grille");
        front_right_door_plastic_1 = GameObject.Find("front_right_door_plastic_1");
        front_right_door_plastic_2 = GameObject.Find("front_right_door_plastic_2");
        front_right_door_plastic_3_pivot = GameObject.Find("front_right_door_plastic_3_pivot");
        front_right_door_plastic_4_pivot = GameObject.Find("front_right_door_plastic_4_pivot");
        front_right_door_reflection = GameObject.Find("front_right_door_reflection");
        front_right_door_rubber = GameObject.Find("front_right_door_rubber");
        front_right_door_shadow = GameObject.Find("front_right_door_shadow");
        front_right_door_window = GameObject.Find("front_right_door_window");

        front_right_door_alcantara_ANIMATOR = front_right_door_alcantara.GetComponent<Animator>();
        front_right_door_body_ANIMATOR = front_right_door_body.GetComponent<Animator>();
        front_right_door_cloth_pivot_ANIMATOR = front_right_door_cloth_pivot.GetComponent<Animator>();
        front_right_door_grille_ANIMATOR = front_right_door_grille.GetComponent<Animator>();
        front_right_door_plastic_1_ANIMATOR = front_right_door_plastic_1.GetComponent<Animator>();
        front_right_door_plastic_2_ANIMATOR = front_right_door_plastic_2.GetComponent<Animator>();
        front_right_door_plastic_3_pivot_ANIMATOR = front_right_door_plastic_3_pivot.GetComponent<Animator>();
        front_right_door_plastic_4_pivot_ANIMATOR = front_right_door_plastic_4_pivot.GetComponent<Animator>();
        front_right_door_reflection_ANIMATOR = front_right_door_reflection.GetComponent<Animator>();
        front_right_door_rubber_ANIMATOR = front_right_door_rubber.GetComponent<Animator>();
        front_right_door_shadow_ANIMATOR = front_right_door_shadow.GetComponent<Animator>();
        front_right_door_window_ANIMATOR = front_right_door_window.GetComponent<Animator>();
    }

    public void passengerfrontdoor(string state)
    {
        front_right_door_alcantara_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_right_door_body_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_right_door_cloth_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_right_door_grille_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_right_door_plastic_1_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_right_door_plastic_2_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_right_door_plastic_3_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_right_door_plastic_4_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_right_door_reflection_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_right_door_rubber_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_right_door_shadow_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        front_right_door_window_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
    }

}
