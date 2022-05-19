using UnityEngine;

namespace Complete
{
    public class IceShell : IShell
    {
        public void UpdateStats(BaseShell baseShell)
        {
            Debug.Log("Ice Shell");
            //throw new System.NotImplementedException();
            baseShell.m_MaxDamage = 120f;
            baseShell.m_ExplosionRadius = 2.5f;
        }
        
        public void Effect()
        {
            Debug.Log("I will freeze enemy");
        }
    }
}