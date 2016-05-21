using UnityEngine;
using System.Collections;

public class ModifyColor : MonoBehaviour {
    //Test
    
    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0F;
    
	// Use this for initialization
	void Start () 
    {
	   InvokeRepeating("BounceDown", .5F, 1F);
       InvokeRepeating("BounceUp", 1F, 1F);
       //Invoke("Rotate", 1F);
	}
	
	// Update is called once per frame
	void Update () 
    {
	   colorUpdate();
     //  playerMovement();
	}
    
    void colorUpdate()
    {
        float t = Mathf.PingPong(Time.time, duration) / duration;
		gameObject.GetComponent<Camera>().backgroundColor = Color.Lerp(color1, color2, t);   
    }
    
    void BounceDown()
    {
        LeanTween.scale(gameObject, new Vector2(25F, 50F), .5F).setEase(LeanTweenType.easeInBack);
    }
    
    void BounceUp()
    {
        LeanTween.scale(gameObject, new Vector2(50F, 100F), .5F).setEase(LeanTweenType.easeOutBack);
    }
}
