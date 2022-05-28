using System.Collections;
using System.Collections.Generic;
using Projectiles;
using Projectiles.Bullet;
using UnityEngine;
using UnityEngine.Pool;

public class Spawner : MonoBehaviour
{
    
    [SerializeField] private Bullet Prefab;

    [SerializeField] private BoxCollider SpawnArea;
    private ObjectPool<Bullet> BulletPool;
    [SerializeField] ParticlePool _particlePool;
    private void Start(){
        InvokeRepeating(nameof(Spawn), 0.6f, 0.6f);
    }

    void Awake() {
        BulletPool = new ObjectPool<Bullet>(CreatePooledObject, OnTakeFromPool, OnReturnToPool, OnDestroyObject, false, 10, 10);
    }
    private Bullet CreatePooledObject() {
        Bullet instance = Instantiate(Prefab, Vector3.zero, Quaternion.identity);
        instance.Disable += ReturnObjectToPool;
        instance.gameObject.SetActive(false);

        return instance;
    }

    private void ReturnObjectToPool(Bullet Instance) {
        if(_particlePool != null && _particlePool.isActiveAndEnabled) {
            _particlePool.Pool.Get().transform.position = Instance.transform.position;
        }
        BulletPool.Release(Instance);
    }

    private void OnTakeFromPool(Bullet Instance) {
        Instance.gameObject.SetActive(true);
        SpawnBullet(Instance);
        Instance.transform.SetParent(transform, true);
    }

    private void OnReturnToPool(Bullet Instance) {
        Instance.gameObject.SetActive(false);
    }

    private void OnDestroyObject(Bullet Instance) {
        Destroy(Instance.gameObject);
    }

    private void Spawn(){
        BulletPool.Get();
    }

    private void SpawnBullet(Bullet instance) {
        Vector3 spawnLocation = new Vector3(
            SpawnArea.transform.position.x + SpawnArea.center.x + UnityEngine.Random.Range(-4f * SpawnArea.bounds.extents.x, SpawnArea.bounds.extents.x ),
            SpawnArea.transform.position.y + SpawnArea.center.y + UnityEngine.Random.Range(-4f * SpawnArea.bounds.extents.x, SpawnArea.bounds.extents.y ),
            SpawnArea.transform.position.z + SpawnArea.center.z + UnityEngine.Random.Range(-4f * SpawnArea.bounds.extents.x, SpawnArea.bounds.extents.z )
        );
        instance.transform.position = spawnLocation;

        instance.Shoot(spawnLocation, SpawnArea.transform.right, 6);
    }
}
