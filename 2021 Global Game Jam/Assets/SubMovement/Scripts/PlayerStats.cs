using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PlayerStats : MonoBehaviour
{

    public float torchRange;
    public float torchDuration;
    public int sonarRange;
    public float sonarSpeed;
    public float hullDurability;
    public float hullMaxHealth;
    public float hullCurrentHealth;
    public float moveSpeed;

    private PlayerMovement pMovement;

    public Light2D pLight;
    private PlayerLight playerLight;

    private SonarScan sonarScan;

    public minimap.MaskComputeShaderObject csObject;
    public GameObject sub_shield;
    private SpriteRenderer shieldTexture;

    public GameObject lightUpgrade;
    private Light2D backLight;
    private SpriteRenderer lightTexture;

    public GameObject sonarUpgrade;
    private SpriteRenderer sonarTexture;

    public MasterInput controls;


    private void Awake()
    {
        controls = new MasterInput();
        controls.PlayerControls.Repair.started += ctx => OnRepair();
    }

    // Start is called before the first frame update
    void Start()
    {
        hullMaxHealth = 100.0f;
        hullCurrentHealth = 100.0f;
        hullDurability = 10.0f;
        pMovement = GetComponent<PlayerMovement>();   

        playerLight = pLight.GetComponent<PlayerLight>();
        sonarScan = GetComponentInChildren<SonarScan>();

        backLight = lightUpgrade.GetComponentInChildren<Light2D>();

        lightTexture = lightUpgrade.GetComponentInChildren<SpriteRenderer>();
        shieldTexture = sub_shield.GetComponent<SpriteRenderer>();
        sonarTexture = sonarUpgrade.GetComponentInChildren<SpriteRenderer>();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        torchRange = playerLight.range;
        torchDuration = playerLight.onDuration;
        moveSpeed = pMovement.moveSpeed;
        sonarRange = sonarScan.scanRadius;
    }

    public void UpgradeTorch()
    {
        backLight.enabled = true;
        lightTexture.enabled = true;
        playerLight.range = 4.5f;
        playerLight.onDuration = 10.0f;
    }

    public void UpgradeHullHealth()
    {        
        shieldTexture.enabled = true;
        hullCurrentHealth += 50.0f;
        hullMaxHealth = 150.0f;
    }

    public void UpgradeMoveSpeed()
    {
        pMovement.moveSpeed = 50.0f;
    }

    public void UpgradeSonarRange()
    {
        sonarTexture.enabled = true;
        sonarScan.scanRadius = 10;
    }

    public void UnlockMapArea(int index)
    {
        switch (index)
        {
            case 1:
                csObject.zone1Flag = true;
                break;
            case 2:
                csObject.zone2Flag = true;
                break;
            case 3:
                csObject.zone3Flag = true;
                break;
            case 4:
                csObject.zone4Flag = true;
                break;
        }

        csObject.CreateNewTexture();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            hullCurrentHealth -= 25;
            if (hullCurrentHealth <= 0)
            {
                GameObject.Find("LevelLoader").GetComponent<LevelLoader>().SwitchScene("Game Over");
            }
        }
        else if (collision.gameObject.CompareTag("Treasure"))
        {
            TreasureControl treasureType = collision.gameObject.GetComponent<TreasureControl>();

            switch (treasureType.reward)
            {
                case PlayerUpgrades.Upgrades.torchUpgrade:
                    UpgradeTorch();
                    break;
                case PlayerUpgrades.Upgrades.sonarUpgrade:
                    UpgradeSonarRange();
                    break;
                case PlayerUpgrades.Upgrades.hullUpgrade:
                    UpgradeHullHealth();
                    break;
                case PlayerUpgrades.Upgrades.mapZone1:
                    UnlockMapArea(1);
                    break;
                case PlayerUpgrades.Upgrades.mapZone2:
                    UnlockMapArea(2);
                    break;
                case PlayerUpgrades.Upgrades.mapZone3:
                    UnlockMapArea(3);
                    break;
                case PlayerUpgrades.Upgrades.mapZone4:
                    UnlockMapArea(4);
                    break;
                case PlayerUpgrades.Upgrades.moveSpdMod:
                    UpgradeMoveSpeed();
                    break;
                default:
                    break;
            }
        }
    }

    void OnRepair()
    {
        Debug.Log("Repairing");
        float repairTime = hullMaxHealth / (hullCurrentHealth * 1.5f);
        StartCoroutine(Repair(repairTime));
    }

    public IEnumerator Repair(float repairTime)
    {
        yield return new WaitForSeconds(repairTime);
        Debug.Log("Repaired");
        hullCurrentHealth = hullMaxHealth;
    }

}
