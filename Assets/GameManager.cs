using UnityEngine;

public class ArcherTest : MonoBehaviour
{
    void Start()
    {
        Archer archer = new Archer("Legolas", 3);
        archer.ShootArrow();
        archer.ShootArrow();
        archer.ShootArrow();
        archer.ShootArrow(); 
    }
}
