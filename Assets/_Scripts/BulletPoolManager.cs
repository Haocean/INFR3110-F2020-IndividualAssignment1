using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;

    //TODO: create a structure to contain a collection of bullets
    private Queue<GameObject> m_BulletPool;

    public int MaxBullets;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool
        m_BulletPool = new Queue<GameObject>();

        for (var count = 0; count < MaxBullets; count++)
        {
            GameObject tmpBullet = bullet;
            tmpBullet.SetActive(false);
            m_BulletPool.Enqueue(tmpBullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        var tmpBullet = m_BulletPool.Dequeue();
        tmpBullet.SetActive(true);
        return bullet;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        bullet.SetActive(false);
        m_BulletPool.Enqueue(bullet);
    }
}
