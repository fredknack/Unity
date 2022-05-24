using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ParticlePool : MonoBehaviour
{
    [SerializeField] private GameObject _particlePrefab;

    IObjectPool<ParticleSystem> m_Pool;

    public IObjectPool<ParticleSystem> Pool
    {
        get
        {
            if (m_Pool == null)
                m_Pool = new ObjectPool<ParticleSystem>(CreatePooledItem, OnTakeFromPool, OnReturnedToPool, OnDestroyPoolObject, true, 10, 10); 
            
            return m_Pool;
        }
    }

    ParticleSystem CreatePooledItem()
    {
        var go = Instantiate(_particlePrefab);
        var ps = go.GetComponent<ParticleSystem>();
        ps.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);

        var main = ps.main;
        main.duration = 1;
        main.startLifetime = 1;
        main.loop = false;

        var returnToPool = go.AddComponent<ReturnToPool>();
        returnToPool.pool = Pool;

        return ps;
    }

    void OnReturnedToPool(ParticleSystem system)
    {
        system.gameObject.SetActive(false);
    }

    void OnTakeFromPool(ParticleSystem system)
    {
        system.gameObject.SetActive(true);
    }

    void OnDestroyPoolObject(ParticleSystem system)
    {
        Destroy(system.gameObject);
    }

    [RequireComponent(typeof(ParticleSystem))]
    public class ReturnToPool : MonoBehaviour
    {
        public ParticleSystem system;
        public IObjectPool<ParticleSystem> pool;

        void Start()
        {
            system = GetComponent<ParticleSystem>();
            var main = system.main;
            main.stopAction = ParticleSystemStopAction.Callback;
        }

        void OnParticleSystemStopped()
        {
            pool.Release(system);
        }
    }
}
