using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public Sprite backgrond;
    public Sprite table;
    public Sprite wall;
    public Sprite backgrond1;
    public Sprite table1;
    public Sprite wall1;
    public Transform canvas;

    enum MODE
    {
        UPGRADES,
        BUFFS
    };

    private MODE mode = MODE.UPGRADES;
    private ColorBlock color = new ColorBlock();
    private ColorBlock originalColor = new ColorBlock();
    private ColorBlock buttonBuyOriginal = new ColorBlock();
    private ColorBlock buttonBuy = new ColorBlock();
    private const int itemDistance = 60;

    void Start()
    {
        originalColor = GameObject.Find("Buffs").GetComponent<Button>().colors;
        color = GameObject.Find("Buffs").GetComponent<Button>().colors;
        buttonBuyOriginal = GameObject.Find("Button").GetComponent<Button>().colors;
        buttonBuy = GameObject.Find("Button").GetComponent<Button>().colors;

        upgradeButton();
    }

    private void changeColor()
    {
        if (mode == MODE.BUFFS)
        {
            color.normalColor = Color.grey;
            color.selectedColor = Color.grey;
            color.pressedColor = Color.grey;
            color.selectedColor = Color.grey;
            GameObject.Find("Buffs").GetComponent<Button>().colors = color;
            color = originalColor;
            GameObject.Find("Upgrades").GetComponent<Button>().colors = color;
        }
        else if (mode == MODE.UPGRADES)
        {
            color.normalColor = Color.grey;
            color.selectedColor = Color.grey;
            color.pressedColor = Color.grey;
            color.selectedColor = Color.grey;
            GameObject.Find("Upgrades").GetComponent<Button>().colors = color;
            color = originalColor;
            GameObject.Find("Buffs").GetComponent<Button>().colors = color;
        }
    }

    public void buffButton()
    {
        mode = MODE.BUFFS;
        changeColor();
    }

    public void upgradeButton()
    {
        mode = MODE.UPGRADES;
        changeColor();

        addItem("Sala Nível 2", "Sala cofortável para estudos", backgrond1, 0);
        addItem("Mesa Nível 2", "Mesa com várias gavetas", table1, 1);
        addItem("Quadro Nível 2", "Rock'n'roll", wall1, 2);
    }

    private void addItem(string name, string description, Sprite image, int numItens)
    {
        buttonBuy.normalColor = Color.grey;
        buttonBuy.selectedColor = Color.grey;
        buttonBuy.pressedColor = Color.grey;
        buttonBuy.selectedColor = Color.grey;

        switch (numItens)
        {
            case 0:
                GameObject.Find("Item1/nome").GetComponentInChildren<Text>().text = name;
                GameObject.Find("Item1/descricao").GetComponentInChildren<Text>().text = description;
                GameObject.Find("Item1/Image").GetComponentInChildren<Image>().sprite = image;
                GameObject.Find("Item1/nome").GetComponentInChildren<Text>().text = name;
                //GameObject.Find("Item/Button").GetComponent<Button>().colors = buttonBuy;
            break;

            case 1:
                GameObject.Find("Item2/nome").GetComponentInChildren<Text>().text = name;
                GameObject.Find("Item2/descricao").GetComponentInChildren<Text>().text = description;
                GameObject.Find("Item2/Image").GetComponentInChildren<Image>().sprite = image;
                GameObject.Find("Item2/nome").GetComponentInChildren<Text>().text = name;
                break;

            case 2:
                GameObject.Find("Item3/nome").GetComponentInChildren<Text>().text = name;
                GameObject.Find("Item3/descricao").GetComponentInChildren<Text>().text = description;
                GameObject.Find("Item3/Image").GetComponentInChildren<Image>().sprite = image;
                GameObject.Find("Item3/nome").GetComponentInChildren<Text>().text = name;
                break;
        }
    }

    public void buyItem(int item)
    {
        GameObject.Find("Item"+item+"/Button").GetComponent<Button>().colors = buttonBuy;
        if (item == 1)
            User.users[0].background = backgrond;
        else if (item == 2)
            User.users[0].table = table;
        else if (item == 3)
            User.users[0].wall = wall;
    }

}
