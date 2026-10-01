using UnityEngine;

public class ASTBEHA : MonoBehaviour
{
    public Transform TARGETPOSI;
    public Transform STPOSI;
    public int TYPE;
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TYPE ==1)
        {
            transform.position = Vector3.MoveTowards(transform.position, TARGETPOSI.position, 2 * Time.deltaTime);
            if (transform.position == TARGETPOSI.position)
            {
                transform.position = STPOSI.position;
            }
        }

        if (TYPE == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 2 * Time.deltaTime);
            if (transform.position == target.position)
            {
                if (target == TARGETPOSI)
                    target = STPOSI;
                else
                    target = TARGETPOSI;
            }
        }
    }
}
