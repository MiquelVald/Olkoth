using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LizScream : MonoBehaviour
{

    public Image lizImage;

    public AudioClip screamSound;
    public AudioSource audioSource;

    public float imageStayTime = 0.01f;
    private float time;

    public float shakeRange = 600f;
    void Start()
    {
        lizImage.enabled = false;

    }

    public void Scream()
    {

        StartCoroutine("ImageAppear");
    }

    // Update is called once per frame
    IEnumerator ImageAppear()
    {
        float time = 0.0f;
        audioSource.PlayOneShot(screamSound);
        lizImage.enabled = true;
        yield return new WaitForSeconds(screamSound.length - 2.6f);
        while (time < screamSound.length)
        {
            time += Time.deltaTime;
        }
        lizImage.enabled = false;
    }

    void Update()
    {
        float elapsed = 0.0f;
        Quaternion originalRotation = lizImage.transform.rotation;

        while (elapsed < screamSound.length)
        {
            elapsed += Time.deltaTime;
            float x = Random.value + 1 * shakeRange;
            lizImage.transform.eulerAngles = new Vector3(originalRotation.x + x, originalRotation.y + x, originalRotation.z);
        }
    }
}
