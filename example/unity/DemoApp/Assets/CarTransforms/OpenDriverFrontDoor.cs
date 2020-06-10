using UnityEngine;
public class OpenDriverFrontDoor : MonoBehaviour
{
    /*********************************************
    * Driver Front Door
    */
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
    /*********************************************
    * Driver Front Door
    */

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

    /*********************************************
    * Driver Back Door
    */
    GameObject back_left_door_alcantara;
    Animator back_left_door_alcantara_ANIMATOR;

    GameObject back_left_door_body;
    Animator back_left_door_body_ANIMATOR;

    GameObject back_left_door_cloth_pivot;
    Animator back_left_door_cloth_pivot_ANIMATOR;

    GameObject back_left_door_grille;
    Animator back_left_door_grille_ANIMATOR;

    GameObject back_left_door_plastic_1;
    Animator back_left_door_plastic_1_ANIMATOR;

    GameObject back_left_door_plastic_2;
    Animator back_left_door_plastic_2_ANIMATOR;

    GameObject back_left_door_plastic_3_pivot;
    Animator back_left_door_plastic_3_pivot_ANIMATOR;

    GameObject back_left_door_plastic_4_pivot;
    Animator back_left_door_plastic_4_pivot_ANIMATOR;

    GameObject back_left_door_reflection;
    Animator back_left_door_reflection_ANIMATOR;

    GameObject back_left_door_rubber;
    Animator back_left_door_rubber_ANIMATOR;

    GameObject back_left_door_shadow;
    Animator back_left_door_shadow_ANIMATOR;

    GameObject back_left_door_window;
    Animator back_left_door_window_ANIMATOR;
    /*********************************************
    * Driver Back Door
    */

    /*********************************************
    * Passenger Back Door
    */
    GameObject back_right_door_alcantara;
    Animator back_right_door_alcantara_ANIMATOR;

    GameObject back_right_door_body;
    Animator back_right_door_body_ANIMATOR;

    GameObject back_right_door_cloth_pivot;
    Animator back_right_door_cloth_pivot_ANIMATOR;

    GameObject back_right_door_grille;
    Animator back_right_door_grille_ANIMATOR;

    GameObject back_right_door_plastic_1;
    Animator back_right_door_plastic_1_ANIMATOR;

    GameObject back_right_door_plastic_2;
    Animator back_right_door_plastic_2_ANIMATOR;

    GameObject back_right_door_plastic_3_pivot;
    Animator back_right_door_plastic_3_pivot_ANIMATOR;

    GameObject back_right_door_plastic_4_pivot;
    Animator back_right_door_plastic_4_pivot_ANIMATOR;

    GameObject back_right_door_reflection;
    Animator back_right_door_reflection_ANIMATOR;

    GameObject back_right_door_rubber;
    Animator back_right_door_rubber_ANIMATOR;

    GameObject back_right_door_shadow;
    Animator back_right_door_shadow_ANIMATOR;

    GameObject back_right_door_window;
    Animator back_right_door_window_ANIMATOR;
    /*********************************************
    * Passenger Back Door
    */

    /*********************************************
    * Trunk
    */
    GameObject trunk_lid_body;
    Animator trunk_lid_body_ANIMATOR;

    GameObject trunk_lid_detail_1_pivot;
    Animator trunk_lid_detail_1_pivot_ANIMATOR;

    GameObject trunk_lid_detail_2_pivot;
    Animator trunk_lid_detail_2_pivot_ANIMATOR;

    GameObject trunk_lid_detail_3_pivot;
    Animator trunk_lid_detail_3_pivot_ANIMATOR;

    GameObject trunk_lid_detail_5_pivot;
    Animator trunk_lid_detail_5_pivot_ANIMATOR;

    GameObject trunk_lid_glass_1;
    Animator trunk_lid_glass_1_ANIMATOR;

    GameObject trunk_lid_glass_2_pivot;
    Animator trunk_lid_glass_2_pivot_ANIMATOR;

    GameObject trunk_lid_glass_3_pivot;
    Animator trunk_lid_glass_3_pivot_ANIMATOR;

    GameObject trunk_lid_logo;
    Animator trunk_lid_logo_ANIMATOR;

    GameObject trunk_lid_plastic_1;
    Animator trunk_lid_plastic_1_ANIMATOR;

    GameObject trunk_lid_plastic_2;
    Animator trunk_lid_plastic_2_ANIMATOR;

    GameObject trunk_lid_red_plastic_pivot;
    Animator trunk_lid_red_plastic_pivot_ANIMATOR;

    GameObject trunk_lid_reflection;
    Animator trunk_lid_reflection_ANIMATOR;
    /*********************************************
    * Trunk
    */

    /*********************************************
    * Frunk
    */
    GameObject hood_body_pivot;
    Animator hood_body_pivot_ANIMATOR;

    GameObject hood_logo_pivot;
    Animator hood_logo_pivot_ANIMATOR;
    /*********************************************
    * Frunk
    */

    void initDriverFrontDoor()
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

    void initDriverBackDoor()
    {
        back_left_door_alcantara = GameObject.Find("back_left_door_alcantara");
        back_left_door_body = GameObject.Find("back_left_door_body");
        back_left_door_cloth_pivot = GameObject.Find("back_left_door_cloth_pivot");
        back_left_door_grille = GameObject.Find("back_left_door_grille");
        back_left_door_plastic_1 = GameObject.Find("back_left_door_plastic_1");
        back_left_door_plastic_2 = GameObject.Find("back_left_door_plastic_2");
        back_left_door_plastic_3_pivot = GameObject.Find("back_left_door_plastic_3_pivot");
        back_left_door_plastic_4_pivot = GameObject.Find("back_left_door_plastic_4_pivot");
        back_left_door_reflection = GameObject.Find("back_left_door_reflection");
        back_left_door_rubber = GameObject.Find("back_left_door_rubber");
        back_left_door_shadow = GameObject.Find("back_left_door_shadow");
        back_left_door_window = GameObject.Find("back_left_door_window");

        back_left_door_alcantara_ANIMATOR = back_left_door_alcantara.GetComponent<Animator>();
        back_left_door_body_ANIMATOR = back_left_door_body.GetComponent<Animator>();
        back_left_door_cloth_pivot_ANIMATOR = back_left_door_cloth_pivot.GetComponent<Animator>();
        back_left_door_grille_ANIMATOR = back_left_door_grille.GetComponent<Animator>();
        back_left_door_plastic_1_ANIMATOR = back_left_door_plastic_1.GetComponent<Animator>();
        back_left_door_plastic_2_ANIMATOR = back_left_door_plastic_2.GetComponent<Animator>();
        back_left_door_plastic_3_pivot_ANIMATOR = back_left_door_plastic_3_pivot.GetComponent<Animator>();
        back_left_door_plastic_4_pivot_ANIMATOR = back_left_door_plastic_4_pivot.GetComponent<Animator>();
        back_left_door_reflection_ANIMATOR = back_left_door_reflection.GetComponent<Animator>();
        back_left_door_rubber_ANIMATOR = back_left_door_rubber.GetComponent<Animator>();
        back_left_door_shadow_ANIMATOR = back_left_door_shadow.GetComponent<Animator>();
        back_left_door_window_ANIMATOR = back_left_door_window.GetComponent<Animator>();
    }

    void initPassengerBackDoor()
    {
        back_right_door_alcantara = GameObject.Find("back_right_door_alcantara");
        back_right_door_body = GameObject.Find("back_right_door_body");
        back_right_door_cloth_pivot = GameObject.Find("back_right_door_cloth_pivot");
        back_right_door_grille = GameObject.Find("back_right_door_grille");
        back_right_door_plastic_1 = GameObject.Find("back_right_door_plastic_1");
        back_right_door_plastic_2 = GameObject.Find("back_right_door_plastic_2");
        back_right_door_plastic_3_pivot = GameObject.Find("back_right_door_plastic_3_pivot");
        back_right_door_plastic_4_pivot = GameObject.Find("back_right_door_plastic_4_pivot");
        back_right_door_reflection = GameObject.Find("back_right_door_reflection");
        back_right_door_rubber = GameObject.Find("back_right_door_rubber");
        back_right_door_shadow = GameObject.Find("back_right_door_shadow");
        back_right_door_window = GameObject.Find("back_right_door_window");

        back_right_door_alcantara_ANIMATOR = back_right_door_alcantara.GetComponent<Animator>();
        back_right_door_body_ANIMATOR = back_right_door_body.GetComponent<Animator>();
        back_right_door_cloth_pivot_ANIMATOR = back_right_door_cloth_pivot.GetComponent<Animator>();
        back_right_door_grille_ANIMATOR = back_right_door_grille.GetComponent<Animator>();
        back_right_door_plastic_1_ANIMATOR = back_right_door_plastic_1.GetComponent<Animator>();
        back_right_door_plastic_2_ANIMATOR = back_right_door_plastic_2.GetComponent<Animator>();
        back_right_door_plastic_3_pivot_ANIMATOR = back_right_door_plastic_3_pivot.GetComponent<Animator>();
        back_right_door_plastic_4_pivot_ANIMATOR = back_right_door_plastic_4_pivot.GetComponent<Animator>();
        back_right_door_reflection_ANIMATOR = back_right_door_reflection.GetComponent<Animator>();
        back_right_door_rubber_ANIMATOR = back_right_door_rubber.GetComponent<Animator>();
        back_right_door_shadow_ANIMATOR = back_right_door_shadow.GetComponent<Animator>();
        back_right_door_window_ANIMATOR = back_right_door_window.GetComponent<Animator>();
    }

    void initTrunk()
    {
        trunk_lid_body = GameObject.Find("trunk_lid_body");
        trunk_lid_detail_1_pivot = GameObject.Find("trunk_lid_detail_1_pivot");
        trunk_lid_detail_2_pivot = GameObject.Find("trunk_lid_detail_2_pivot");
        trunk_lid_detail_3_pivot = GameObject.Find("trunk_lid_detail_3_pivot");
        trunk_lid_detail_5_pivot = GameObject.Find("trunk_lid_detail_5_pivot");
        trunk_lid_glass_1 = GameObject.Find("trunk_lid_glass_1");
        trunk_lid_glass_2_pivot = GameObject.Find("trunk_lid_glass_2_pivot");
        trunk_lid_glass_3_pivot = GameObject.Find("trunk_lid_glass_3_pivot");
        trunk_lid_logo = GameObject.Find("trunk_lid_logo");
        trunk_lid_plastic_1 = GameObject.Find("trunk_lid_plastic_1");
        trunk_lid_plastic_2 = GameObject.Find("trunk_lid_plastic_2");
        trunk_lid_red_plastic_pivot = GameObject.Find("trunk_lid_red_plastic_pivot");
        trunk_lid_reflection = GameObject.Find("trunk_lid_reflection");

        trunk_lid_body_ANIMATOR = trunk_lid_body.GetComponent<Animator>();
        trunk_lid_detail_1_pivot_ANIMATOR = trunk_lid_detail_1_pivot.GetComponent<Animator>();
        trunk_lid_detail_2_pivot_ANIMATOR = trunk_lid_detail_2_pivot.GetComponent<Animator>();
        trunk_lid_detail_3_pivot_ANIMATOR = trunk_lid_detail_3_pivot.GetComponent<Animator>();
        trunk_lid_detail_5_pivot_ANIMATOR = trunk_lid_detail_5_pivot.GetComponent<Animator>();
        trunk_lid_glass_1_ANIMATOR = trunk_lid_glass_1.GetComponent<Animator>();
        trunk_lid_glass_2_pivot_ANIMATOR = trunk_lid_glass_2_pivot.GetComponent<Animator>();
        trunk_lid_glass_3_pivot_ANIMATOR = trunk_lid_glass_3_pivot.GetComponent<Animator>();
        trunk_lid_logo_ANIMATOR = trunk_lid_logo.GetComponent<Animator>();
        trunk_lid_plastic_1_ANIMATOR = trunk_lid_plastic_1.GetComponent<Animator>();
        trunk_lid_plastic_2_ANIMATOR = trunk_lid_plastic_2.GetComponent<Animator>();
        trunk_lid_red_plastic_pivot_ANIMATOR = trunk_lid_red_plastic_pivot.GetComponent<Animator>();
        trunk_lid_reflection_ANIMATOR = trunk_lid_reflection.GetComponent<Animator>();
    }

    void initFrunk()
    {
        hood_body_pivot = GameObject.Find("hood_body_pivot");
        hood_logo_pivot = GameObject.Find("hood_logo_pivot");

        hood_body_pivot_ANIMATOR = hood_body_pivot.GetComponent<Animator>();
        hood_logo_pivot_ANIMATOR = hood_logo_pivot.GetComponent<Animator>();
    }

    // Awake is called before Start
    void Awake()
    {
/*         initDriverFrontDoor();
        initPassengerFrontDoor(); */
/*         initDriverBackDoor();
        initPassengerBackDoor(); */
    }

    // Start is called before the first frame update
    void Start()
    {
        initTrunk();
        initFrunk();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// Flutter Bridging method to animate openings (open/close)
    public void DoorOpened(string state)
    {
        string[] part = state.Split(':');

        switch (part[0])
        {
            case "driverfrontdoor":
                driverfrontdoor(part[1]);
                break;
            case "passengerfrontdoor":
                passengerfrontdoor(part[1]);
                break;
            case "driverbackdoor":
                driverbackdoor(part[1]);
                break;
            case "passengerbackdoor":
                passengerbackdoor(part[1]);
                break;
            case "trunk":
                trunkdoor(part[1]);
                break;
            case "frunk":
                frunkdoor(part[1]);
                break;
            default: break;
        }

    }

    public void driverfrontdoor(string state)
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

    public void driverbackdoor(string state)
    {
        back_left_door_alcantara_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_left_door_body_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_left_door_cloth_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_left_door_grille_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_left_door_plastic_1_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_left_door_plastic_2_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_left_door_plastic_3_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_left_door_plastic_4_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_left_door_reflection_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_left_door_rubber_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_left_door_shadow_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_left_door_window_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
    }

    public void passengerbackdoor(string state)
    {
        back_right_door_alcantara_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_right_door_body_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_right_door_cloth_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_right_door_grille_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_right_door_plastic_1_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_right_door_plastic_2_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_right_door_plastic_3_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_right_door_plastic_4_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_right_door_reflection_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_right_door_rubber_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_right_door_shadow_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        back_right_door_window_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
    }

    public void trunkdoor(string state)
    {
        trunk_lid_body_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_detail_1_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_detail_2_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_detail_3_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_detail_5_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_glass_1_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_glass_2_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_glass_3_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_logo_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_plastic_1_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_plastic_2_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_red_plastic_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        trunk_lid_reflection_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
    }

    public void frunkdoor(string state)
    {
        hood_body_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
        hood_logo_pivot_ANIMATOR.SetBool("DoorOpened", bool.Parse(state));
    }

}