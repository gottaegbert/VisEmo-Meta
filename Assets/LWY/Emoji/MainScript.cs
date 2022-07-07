using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MainScript : MonoBehaviour
{
    public Image CameraImage;
    //public Button ExitButton;
    //String[] labels = {"Neutralit�", "Felicit�", "Sorpresa", "Tristezza", "Rabbia", "Disgusto", "Paura"};

    //public Text PrevalentEmotion;
    public Text Neutral;
    public Text Happiness;
    public Text Surprise;
    public Text Sadness;
    public Text Anger;
    public Text Disgust;
    public Text Fear;
    public Text Engagment;
    public Text valence;



    const int MAX_NUM_HUMANS = 5;
    const int RESULT_EACH_HUMAN = 11;

    private bool _isLoaded;
    private bool _ready;
    private Texture2D tex;
    private Color32[] pixel32;

    private GCHandle pixelHandle;
    private IntPtr pixelPtr;

    int camWidth = 0;
    int camHeight = 0;

    public static double[] results;
    //public double[] newResults;


    // Define the functions which can be called from the .dll.
    internal static class OpenCVInterop
    {
        [DllImport("Emoj_plugin")]
        internal static extern bool loadModels();
        [DllImport("Emoj_plugin")]
        internal static extern bool initCamera(ref int outCameraWidth, ref int outCameraHeight);
        [DllImport("Emoj_plugin")]
        internal static extern int releaseCamera();

        [DllImport("Emoj_plugin")]
        internal static extern IntPtr processImage(IntPtr data, int width, int height, ref double[] results, int MAX_NUM_HUMANS, int RESULT_EACH_HUMAN);
    }


    // Start is called before the first frame update
    void Start()
    {
        //ExitButton.onClick.AddListener(OnExitButtonClick);
        InitTexture();
        CameraImage.material.mainTexture = tex;
        //string path = Directory.GetCurrentDirectory();

        Neutral.text = "Neutral:";
        Happiness.text = "Happiness:";
        Surprise.text = "Surprise:";
        Sadness.text = "Sadness:";
        Anger.text = "Anger:";
        Disgust.text = "Disgust:";
        Fear.text = "Fear:";

        // Debug.Log(path);
        _isLoaded = OpenCVInterop.loadModels();
        Debug.Log("models loaded?" + _isLoaded);

        _ready = OpenCVInterop.initCamera(ref camWidth, ref camHeight);
        Debug.Log("Camera ready?" + _ready);
    }

    // Update is called once per frame
    void Update()
    {
        results = new double[MAX_NUM_HUMANS * RESULT_EACH_HUMAN];
        //newResults = new double[MAX_NUM_HUMANS * RESULT_EACH_HUMAN];


        if (_isLoaded && _ready)
        {

            IntPtr r = OpenCVInterop.processImage(pixelPtr, tex.width, tex.height, ref results, MAX_NUM_HUMANS, RESULT_EACH_HUMAN);
            int arrayLength = Marshal.ReadInt32(r);
            /*
                0. timestamp format "MM/dd/yyyy hh:mm:ss.fff";
				1.indexPrevalentEmotion;
				2.emotionPreds[0];
				    ...
    			8.emotionPreds[6];
				9.engagement;
				10.valence;
                */
            //Debug.Log("LAST ELEMENT INSIDE results --->:" + results[MAX_NUM_HUMANS * RESULT_EACH_HUMAN -1]);
            if (results[0] != 0)
            {
                DateTimeOffset tempo = DateTimeOffset.FromUnixTimeMilliseconds((long)results[0]);
                
                //Debug.Log("timestamp:" + tempo.ToLocalTime().ToString("MM/dd/yyyy hh:mm:ss.fff"));
                // Debug.Log("Prevalent Emotion:" + results[1]);
            }
            //PrevalentEmotion.text = "Prevalent Emotion:" + (results[1]).ToString();
            Neutral.text = "Neutral:" + (Math.Round(results[2] * 100, 2)).ToString();
            Happiness.text = "Happiness:" + (Math.Round(results[3] * 100, 2)).ToString();
            Surprise.text = "Surprise:" + (Math.Round(results[4] * 100, 2)).ToString();
            Sadness.text = "Sadness:" + (Math.Round(results[5] * 100, 2)).ToString();
            Anger.text = "Anger:" + (Math.Round(results[6] * 100, 2)).ToString();
            Disgust.text = "Disgust:" + (Math.Round(results[7] * 100, 2)).ToString();
            Fear.text = "Fear:" + (Math.Round(results[8] * 100, 2)).ToString();
            Engagment.text = "Engagment:" + (results[9]).ToString();
            valence.text = "valence:" + (results[10]).ToString();
            


            // Debug.Log("Happiness:" + results[3]);
            // Debug.Log("Engagment:" + results[9]);
            // Debug.Log("valence:" + results[10]);
            tex.SetPixels32(pixel32);
            tex.Apply();

        }

    }


    void InitTexture()
    {
        tex = new Texture2D(1280, 720, TextureFormat.ARGB32, false);
        pixel32 = tex.GetPixels32();
        //Pin pixel32 array
        pixelHandle = GCHandle.Alloc(pixel32, GCHandleType.Pinned);
        //Get the pinned address
        pixelPtr = pixelHandle.AddrOfPinnedObject();
    }

    private void OnApplicationQuit()
    {
        pixelHandle.Free();
        OpenCVInterop.releaseCamera();
    }
}
