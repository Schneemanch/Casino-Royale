using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour {
	public enum PlayerType{
		HUMAN, AI
	};
	public static float MAX_HEALTH = 100f;

	public float health = MAX_HEALTH;
	public string fighterName;
	public Fighter opponent;
	public PlayerType player;

	protected Animator animator;
    protected Animation animation;
	private Rigidbody myBody;
	private AudioSource audioPlayer;

    // For AI?? o.O
    private float random;
    private float randomSetTime;

    //Testing movement
    //public float mSpeed;

	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody>();
		animator = GetComponent<Animator>();
        animation = GetComponent<Animation>();
		audioPlayer = GetComponent<AudioSource>();
	}

	//These are purely for testing, since we have no swipe controls
	//I have set up keyboard controls in order to make sure hitboxes 
	//and movement work properly
	///*
	public void UpdateHumanInput (){
		if (Input.GetKeyDown (KeyCode.D)){
			animator.SetTrigger("DodgeFdTrigger");
		}
		/*
		if (Input.GetAxis ("Horizontal") > 0.1){
			animator.SetBool ("DodgeFdTrigger", true);
		}
		else{
			animator.SetBool ("DodgeFdTrigger", false);
		}*/
		if (Input.GetKeyDown (KeyCode.A)){
			animator.SetTrigger("DodgeBkTrigger");
		}
		if (Input.GetKeyDown (KeyCode.P)){
			animator.SetTrigger("PunchTrigger");
		}
		if (Input.GetKeyDown (KeyCode.K)){
			animator.SetTrigger("KickTrigger");
		}
		if (Input.GetKeyDown (KeyCode.B)){
			animator.SetTrigger("Bock");
            animator.SetBool("isBlocking", true);
		}
        // Need this for blocking hopefully
        if (Input.GetKeyUp(KeyCode.B)){
            animator.SetBool("isBlocking", false);
            animator.ResetTrigger("Bock");
        }
	}

    void UpdateAIInput()
    {
        //TODO: Rework the if statements logic
        animator.SetBool("enable",enabled);
        animator.SetFloat("distanceToOpponent", getDistanceToOpponent());
    
        if(animator.GetFloat("distanceToOpponent") > 1.5) // Far
        {
            // WHY DOESNT THIS WORK
            animator.SetBool("DodgeFd", true);
            animator.SetTrigger("DodgeFdTrigger");
        } else // Close
        {
            animator.SetBool("DodgeFd", false);
            if (animator.GetFloat("health") < 0.1) {
                animator.SetBool("DodgeBk", true);
            }
            /*
            if(animator.GetFloat("health") < 0.5)
            {
                animator.SetTrigger("Bock");
            }
            */
        }

        // Random function to prevent machine punching/kicking
        if(Time.time - randomSetTime > 1)
        {
            random = Random.value;
            randomSetTime = Time.time;
        }
        animator.SetFloat("random", random);
    }

	//*/
	// Update is called once per frame
	void Update () {
		animator.SetFloat ("health", currentHealth);

		if (opponent != null){
			animator.SetFloat ("opponent_health", opponent.currentHealth);
		}
		else{
			animator.SetFloat("opponent_health", 1);
		}
		//This is also associated with the keyboard testing
		///*
		if (player == PlayerType.HUMAN){
			UpdateHumanInput ();
		}
        else { // Allows AI input
            UpdateAIInput();
        }

		if (health <= 0 && !animator.GetBool("Dead")){
			animator.SetBool("Dead", true);
            // This works, hilariously....
            animator.Play("Knockout");
		}
	}
	
	public void playSound(AudioClip sound){
		GameUtils.playSound (sound, audioPlayer);
	}

    //WHERE IS THIS FUNCTION CALLED
    //Adding block functionality
	public virtual void hurt(float damage){
        
	   if (health >= damage){

            // Maybe reduce damage by more than 75%?
            if (animator.GetBool("isBlocking"))
            {
                health -= damage/4;
            }
            else
            {
                health -= damage;
            }
        }
		else{
			health = 0;
		}

		if (health > 0){
			animator.SetTrigger("Hit");
		}
    }

	public float currentHealth{
		get{
			return health/MAX_HEALTH;
		}
	}

	public Rigidbody body{
		get{
			return this.myBody;
		}
	}
    
    // Directly from youtube series
    private float getDistanceToOpponent()
    {
        return Mathf.Abs(transform.position.x - opponent.transform.position.x);
    }
}
