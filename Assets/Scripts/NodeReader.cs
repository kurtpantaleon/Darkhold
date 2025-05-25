using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XNode;

public class NodeReader : MonoBehaviour
{
    public TMP_Text dialog;
    public Sprite backgroundImage;
    public GameObject ImageGO;
    public NodeGraph graph;
    public BaseNode currentNode;
    public GameObject characterSheet;

    public TMP_Text buttonAText;
    public TMP_Text buttonBText;
    public TMP_Text buttonCText;
    public TMP_Text buttonDText;

    public GameObject buttonA;
    public GameObject buttonB;
    public GameObject buttonC;
    public GameObject buttonD;

    public GameObject nextButtonGO;

    public AudioSource audioSource;
    public AudioClip suspenseClip;
    public AudioClip adventureClip;
    public AudioClip dramaClip;
    public AudioClip happyClip;
    public Sprite actorImage; 

    public float slideDuration = 2.0f; 

    public RectTransform actorImageTransform; 
    public Vector2 offScreenPosition = new Vector2(-1163, 266);
    public Vector2 onScreenPosition = new Vector2(0, 0); 
    public float nodeReaderslideDuration = 2.5f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null) {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        currentNode = GetStartNode();
        AdvanceDialog();
    }

    public BaseNode GetStartNode()
    {
        return graph.nodes.Find(node => node is BaseNode && node.name == "Start") as BaseNode;
    }

    public void AdvanceDialog()
    {
        var nextNode = GetNextNode(currentNode);
        if(nextNode != null)
        {
            currentNode = nextNode;
            DisplayNode(currentNode);
        }
        else
        {
            Debug.Log("nothing found");
        }
    }

    private BaseNode GetNextNode(BaseNode node)
    {
        if (node is MultipleChoiceDialog)
        {
            GameObject clickButton = EventSystem.current.currentSelectedGameObject;

            TMP_Text buttonText = clickButton.GetComponentInChildren<TMP_Text>();

            if (buttonText.text == ((MultipleChoiceDialog)node).a)
            {
                return currentNode.GetOutputPort("a")?.Connection.node as BaseNode;
            }
            if (buttonText.text == ((MultipleChoiceDialog)node).b)
            {
                return currentNode.GetOutputPort("b")?.Connection.node as BaseNode;
            }
            if (buttonText.text == ((MultipleChoiceDialog)node).c)
            {
                return currentNode.GetOutputPort("c")?.Connection.node as BaseNode;
            }
            if (buttonText.text == ((MultipleChoiceDialog)node).d)
            {
                return currentNode.GetOutputPort("d")?.Connection.node as BaseNode;
            }

            return currentNode.GetOutputPort("a")?.Connection.node as BaseNode;
        }
        else if (node is AbilityCheckNode)
        {
            int d20 = Random.Range(0, 21);
            if ((d20 + characterSheet.gameObject.GetComponent<CharacterStats>().survival) >= ((AbilityCheckNode)node).getDC())
            {
                return currentNode.GetOutputPort("success")?.Connection.node as BaseNode;
            }
            else
            {
                return currentNode.GetOutputPort("failed")?.Connection.node as BaseNode;
            }
        }
        else
        {
            return currentNode.GetOutputPort("exit")?.Connection.node as BaseNode;
        }
    }

    public void DisplayNode(BaseNode node) {
        dialog.text = node.getDialogText();
        backgroundImage = node.GetSprite();
        ImageGO.GetComponent<UnityEngine.UI.Image>().sprite = backgroundImage;

        if (node is SimpleDialogV2 SimpleDialogV2) {
            if (SimpleDialogV2.actorImage != null) {
                actorImageTransform.GetComponent<UnityEngine.UI.Image>().sprite = SimpleDialogV2.actorImage;
                actorImageTransform.gameObject.SetActive(true);
            } else {
                actorImageTransform.gameObject.SetActive(false); 
            }

            if (SimpleDialogV2.slideInActor) {
                StartCoroutine(SlideActorIn());
            } else {
                actorImageTransform.anchoredPosition = onScreenPosition;
            }
        }

        if (node is MultipleChoiceDialog multipleChoiceNode) {
            nextButtonGO.SetActive(false);

            if (!string.IsNullOrWhiteSpace(multipleChoiceNode.a)) {
                buttonA.SetActive(true);
                buttonAText.text = multipleChoiceNode.a;
            } else {
                buttonA.SetActive(false);
            }

            if (!string.IsNullOrWhiteSpace(multipleChoiceNode.b)) {
                buttonB.SetActive(true);
                buttonBText.text = multipleChoiceNode.b;
            } else {
                buttonB.SetActive(false);
            }

            if (!string.IsNullOrWhiteSpace(multipleChoiceNode.c)) {
                buttonC.SetActive(true);
                buttonCText.text = multipleChoiceNode.c;
            } else {
                buttonC.SetActive(false);
            }

            if (!string.IsNullOrWhiteSpace(multipleChoiceNode.d)) {
                buttonD.SetActive(true);
                buttonDText.text = multipleChoiceNode.d;
            } else {
                buttonD.SetActive(false);
            }
        } 
        else if (node is SimpleDialogV4) {
            buttonA.SetActive(false);
            buttonB.SetActive(false);
            buttonC.SetActive(false);
            buttonD.SetActive(false);
            nextButtonGO.SetActive(true);
        }
        else {
            buttonA.SetActive(false);
            buttonB.SetActive(false);
            buttonC.SetActive(false);
            buttonD.SetActive(false);
            nextButtonGO.SetActive(true);
        }

        if (node is SimpleDialogV4 SimpleDialogV) {
            switch (SimpleDialogV.backgroundMusic) {
                case SimpleDialogV4.BackgroundMusicType.SUSPENSE:
                    audioSource.clip = suspenseClip;
                    break;
                case SimpleDialogV4.BackgroundMusicType.ADVENTURE:
                    audioSource.clip = adventureClip;
                    break;
                case SimpleDialogV4.BackgroundMusicType.DRAMA:
                    audioSource.clip = dramaClip;
                    break;
                case SimpleDialogV4.BackgroundMusicType.HAPPY:
                    audioSource.clip = happyClip;
                    break;
            }
            audioSource.Play();
        }
    }

    IEnumerator SlideActorIn() {
        float elapsedTime = 0f;
        Vector2 startPos = offScreenPosition;
        Vector2 targetPos = onScreenPosition;

        while (elapsedTime < nodeReaderslideDuration) {
            float t = elapsedTime / nodeReaderslideDuration;
            t = t * t * (3f - 2f * t); 
            actorImageTransform.anchoredPosition = Vector2.Lerp(startPos, targetPos, t);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        actorImageTransform.anchoredPosition = targetPos; 
    }
}
