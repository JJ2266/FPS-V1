using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] Image DamageFlash;
    [SerializeField] TMP_Text currentAmmoText;
    [SerializeField] TMP_Text maxAmmoText;

    FPSController player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FPSController>();
        
    }
    public void TakeDamage()
    {
        healthBar.fillAmount -= 0.1f;
        StartCoroutine(Reset());
    }
    IEnumerator Reset()
    {
        
        yield return new WaitForSeconds(0.3f);
        DamageFlash.enabled = false;
    }
    public void SubractAmmo(int amount)
    {
       int i = int.Parse(currentAmmoText.text);
        i -= amount;
        currentAmmoText.text = i.ToString();
    }
    public void AddAmmo(int amount)
    {
        int i = int.Parse(currentAmmoText.text);
        i += amount;
        currentAmmoText.text = i.ToString();
    }
}
