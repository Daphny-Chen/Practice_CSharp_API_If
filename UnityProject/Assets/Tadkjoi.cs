using UnityEngine;

public class Tadkjoi : MonoBehaviour
{

    private Animator anr_eat;
    private bool run;


    // Use this for initialization
    void Start()
    {
        anr_eat = gameObject.GetComponent<Animator>();
        run = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            anr_eat.SetTrigger("吃飯觸發器");

        }
        if ((Input.GetKey(KeyCode.R)))

        {
            anr_eat.SetBool("跑步開關", true);
        }
        else
        {
            anr_eat.SetBool("跑步開關", false);
        }

    }
}
