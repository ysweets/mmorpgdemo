using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Data;
using Managers;
using Models;
using SkillBridge.Message;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIQuestItem : ListView.ListViewItem
{
    public Text title;
    public Image background;
    public Sprite normalBg;
    public Sprite selectedBg;

    public override void onSelected(bool selected)
    {
        this.background.overrideSprite = selected ? selectedBg : normalBg;
    }

    public Quest quest;
    void Start(){

    }

    public void SetQuestInfo(Quest item)
    {
        this.quest = item;
        if (this.title != null) this.title.text = this.quest.Define.Name;
    }
}
