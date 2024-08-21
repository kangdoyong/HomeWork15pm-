using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading;
using UnityEngine;

public class HomeWork2 : MonoBehaviour
{
    void Start()
    {

    }

    public int Power(int operand, int count)
    {
        int result = 1;
        for (int i = 0; i < count; i++)
        {
            result *= operand;
        }
        return result;
    }

    public float Power(float operand, int count)
    {
        float result = 1f;
        for (int i = 0; i < count; i++)
        {
            result *= operand;
        }
        return result;
    }

    public double Power(double operand, int count)
    {
        double result = 1.0;
        for (int i = 0; i < count; i++)
        {
            result *= operand;
        }
        return result;
    }

    private T Instantiate<T>() where T : new()
    {
        return new T();
    }

    //private float GetDamage<T>(T var1, T var2) : Weapon
    //{
    //    if (var1 is Axe axe)
    //    {
    //        return axe.weight;
    //    }
    //    else return -1;
    //}
    
    private Dictionary<int, List<int>> GetDictionary(List<int> list)
    {
        List<int> newList = new List<int>();
        foreach (int i in list)
        {
            if (!newlist.Contains(i)) newList.Add(i);
        }
        list = newList;
    
        var returnDict = new Dictionary<int, List<int>>();
    
        foreach (int num in list)
        {
            var addList = new List<int>();
            for (int i = 0; i < num; i++)
            {
                addList.Add(0);
            }
            returnDict.Add(num, addList);
        }
        return returnDict;
    }
}

public class Character
{
    private string characterName;
    private float health;
    private float maxHealth;
    private List<Weapon> weaponList;
    private int weaponIndex;

    public Weapon CurrentWeapon
    {
        // 프로피터: get, set, init
        get
        {
            return weaponList[weaponIndex];
        }   // get: 특정 값을 불러오기 위한 함수
        // public Weapon get():
        // var weapon = CurrentWeapon; -> var weapon = weaponList[weaponIndex];
        private set
        {
            weaponList[weaponIndex] = value;
        }   // set: 특정 필드에 값을 대입하기 위한 함수
    }   // prviate void set(Weapon value)
        // CurrentWeapon = new Weapon(); -> weaponList[weaponIndex] = new Weapon();

    public Character(string characterName, float maxHealth)
    {
        this.characterName = characterName;
        this.maxHealth = maxHealth;
        health = maxHealth;
        weaponIndex = 0;
        weaponList = new();
    }

    public void AddWeapon(Weapon weapon)
    {
        weaponList.Add(weapon);
    }

    public void SwitchWeapon(int index)
    {
        if (index < 0 || index >= weaponList.Count) return;
        weaponIndex = index;
    }

    public void Attack(Character character)
    {
        CurrentWeapon.Attack(character);
    }

    public void GetDamage(float damage)
    {
        health -= damage;
        if (health <= 0) Die();
    }

    public void Die()
    {
        Debug.Log($"{characterName} Died!");
    }

}

public abstract class Weapon
{
    prviate float damage;

    public virtual void Attack(Character character)
    {
        character.GetDamage(damage);
    }

}

public class Axe : Weapon
{
    public override void Attack(Character character)
    {
        base.Attack(character);
        Debug.Log("Axe Attack!");
    }
}

public class Gun : Weapon
{
    public override void Attack(Character character)
    {
        base.Attack(character);
        Debug.Log("Gun Shot!");
    }
}