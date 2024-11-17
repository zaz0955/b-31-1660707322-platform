using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    public HealthBar healthBar;
    public Animator anim;
    public Rigidbody2D rb;

    public virtual void Init (int newHealth)
    {
        health = newHealth;
        healthBar.SetMaxHealth(newHealth);

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        return false;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
<<<<<<< HEAD

        healthBar.UpdateHealthBar(Health);

=======
        Debug.Log($"{this.name} took damage {damage}, Remeaning Health {Health}");
>>>>>>> fd487ee8ebcb650c0aa855a62a0961c569afda37
        IsDead();
    }
    
}
