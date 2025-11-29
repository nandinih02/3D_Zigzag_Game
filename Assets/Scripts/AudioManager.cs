using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance = null;
    void Awake()
    {
        if(instance!=null && instance!= this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
