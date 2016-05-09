using UnityEngine;
using System.Collections;

public class Quest : MonoBehaviour
{
    private static Quest currentQuest;
    uint questId;
    string title;
    string description;
    uint nextQuestId;
    enum Status { Disabled, In_Progress, Failed, Completed}
    Status status = Status.Disabled;
    public string Title { get { return title; } }
    public string Description { get { return description; } }
    public static Quest Current { get { return currentQuest; } }
    public Quest(uint id, string title, string description, uint nextId)
    {
        this.questId = id;
        this.title = title;
        this.description = description;
        this.nextQuestId = nextId;
        this.status = Status.In_Progress;
    }
    void Awake()
    {
        nextQuestId = 1;
        NextQuest();
    }
   public void NextQuest()
    {
        currentQuest = new XmlReader().Read(new XmlReader().LoadFile("QuestsDescription"), nextQuestId);
        questId = currentQuest.questId;
        title = currentQuest.title;
        description = currentQuest.description;
        nextQuestId = currentQuest.nextQuestId;
    }
    public void EndQuest(bool completed)
    {
        NextQuest();
        questId = currentQuest.questId;
        title = currentQuest.title;
        description = currentQuest.description;
        nextQuestId = currentQuest.nextQuestId;
        status = completed ? Status.Completed : Status.Failed;
    }
    public override string ToString()
    {
        return "ID: " + questId.ToString() + "\n Title: " + title + "\n Description: " + description; 
    }
}
