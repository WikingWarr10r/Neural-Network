using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeuralNet : MonoBehaviour
{
    public List<float> inputList;
    public List<float> inputListWeights;
    public List<float> hiddenLayer1;
    public List<float> hiddenLayer1Weights;

    //important
    private float output;
    private float middleBit;
    private float e = 2.7182818284590452353602874713527f;

    public float outputpp;

    public float Sigmoid(List<float> inputs, List<float> weights, float bias)
    {
        middleBit = 0f;
        for (int i = 0; i < inputs.Count; i++)
        {
            middleBit = middleBit + (inputs[i] * weights[i]);
        }
        output = 1 / (1 + Mathf.Pow(e, 0 - middleBit - bias));

        return output;
    }

    //TEST!!!! Remove before final project
    void Update()
    {
        hiddenLayer1.Clear();
        outputpp = 0f;

        for (int i = 0; i < inputList.Count; i++)
        {
            hiddenLayer1.Add(Sigmoid(inputList, inputListWeights, -2f));
        }

        outputpp = Sigmoid(hiddenLayer1, hiddenLayer1Weights, -2f);

        Debug.Log(outputpp);
    }
}
