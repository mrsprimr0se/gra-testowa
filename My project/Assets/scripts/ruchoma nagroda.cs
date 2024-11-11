using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruchomanagroda : MonoBehaviour
{

    public playerController playerController;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public MeshRenderer meshRenderer;
    public CapsuleCollider capsuleCollider;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        meshRenderer = GetComponent<MeshRenderer>();
        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z + 40 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerController.zebranePunkty++;
            Debug.Log(playerController.zebranePunkty);

            audioSource.PlayOneShot(audioClip);

            meshRenderer.enabled = false;
            capsuleCollider.enabled = false;

        }
    }
}

