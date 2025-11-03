using UnityEngine;

public class Archer : Character
{
    public int arrows;

    public Archer(string name, int arrows) : base(name)
    {
        this.arrows = arrows;
    }

    public void ShootArrow()
    {
        if (arrows > 0)
        {
            arrows--;
            Debug.Log(name + " shot an arrow. " + arrows + " arrows left.");
        }
        else
        {
            Debug.Log(name + " has no arrows left!");
        }
    }
}
