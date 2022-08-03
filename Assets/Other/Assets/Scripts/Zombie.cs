using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.XR.CoreUtils;

public class Zombie : MonoBehaviour
{
    public AudioClip deathAudio;
    public Transform target;
    private NavMeshAgent agent;
    private Rigidbody[] rbs;

    // Start is called before the first frame update
    void Start()
    {
        rbs = GetComponentsInChildren<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        //target = FindObjectOfType<UnityEngine.XR.Interaction.Toolkit.XRRig>().transform;
        target = FindObjectOfType<XROrigin>().transform;
        DisactivateRagdoll();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);

        if (Vector3.Distance(target.position, transform.position) < 0.5f)
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void Death()
    {
        ActivateRagdoll();
        agent.enabled = false;
        GetComponent<Animator>().enabled = false;
        GetComponent<AudioSource>().PlayOneShot(deathAudio);
        Destroy(this);
    }

    void ActivateRagdoll()
    {
        foreach (var item in rbs)
        {
            item.isKinematic = false;
        }
    }

    void DisactivateRagdoll()
    {
        foreach(var item in rbs)
        {
            item.isKinematic = true;
        }
    }
}
