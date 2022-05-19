using UnityEngine;

namespace Complete
{
    public class FireShell : IShell
    {
        public void UpdateStats(BaseShell baseShell)
        {
            Debug.Log("Fire Shell");
            //throw new System.NotImplementedException();
            baseShell.m_MaxDamage = 50f;
            baseShell.m_ExplosionRadius = 5f;  
        }

        public void Effect()
        {
            Debug.Log("I will burn enemy");
        }
    }
}