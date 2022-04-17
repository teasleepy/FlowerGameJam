using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    [SerializeField] private DialogueObject testDialogue;

    private TypewriterEffect typewriterEffect;

    private void Start()
    {
        typewriterEffect = GetComponent<TypewriterEffect>();
        //typewriterEffect = GetComponent<TypewriterEffect>();
        ShowDialogue(testDialogue);
        //textLabel.text = "hello";
        //GetComponent<TypewriterEffect>().Run(textToType: "This is text", textLabel);
    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {
        StartCoroutine(routine: StepThroughDialouge(dialogueObject));
    }

    private IEnumerator StepThroughDialouge(DialogueObject dialogueObject)
    {
        foreach(string dialogue in dialogueObject.Dialogue)
        {
            yield return typewriterEffect.Run(dialogue, textLabel);
        }
    }
}
